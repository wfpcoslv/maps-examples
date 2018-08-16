Imports System
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
' Requiere Newtonsoft JSON, descargar desde: http://www.newtonsoft.com/json
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class DataLoader

    Private _cursorPos As Int32
    Private TextFileTable As DataTable
    Private ColumnNames(20) As String
    Private totalColumns As Int32
    Private api As MAPSAPI
    Private updated As Boolean
    Private saved As Boolean

    Private Sub DataLoader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._cursorPos = 0
        TextFileTable = Nothing
        Me.updated = False
        Me.saved = False
    End Sub

    Public Sub SetAPI(ByRef apiInstance As MAPSAPI)
        Me.api = apiInstance
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFile.Click
        If (Me.updated And Not Me.saved) Then
            If MsgBox("Existen datos sin guardar: ¿Está seguro de continuar? (Perderá sus datos)", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                OpenFileDialog1.ShowDialog()
            End If
        Else
            OpenFileDialog1.ShowDialog()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(OpenFileDialog1.FileName)

        txtFileName.Text = OpenFileDialog1.FileName

        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")

        Dim Column As DataColumn
        Dim Row As DataRow
        Dim UpperBound As Int32
        Dim ColumnCount As Int32
        Dim CurrentRow As String()
        Dim RowCounter As Int32

        RowCounter = 0

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    If TextFileTable Is Nothing Then
                        TextFileTable = New DataTable("TextFileTable")
                        UpperBound = CurrentRow.GetUpperBound(0)
                        For ColumnCount = 0 To UpperBound
                            Column = New DataColumn()
                            Column.DataType = System.Type.GetType("System.String")
                            ColumnNames(ColumnCount) = CurrentRow(ColumnCount).ToString
                            Column.ColumnName = ColumnNames(ColumnCount)
                            Column.Caption = ColumnNames(ColumnCount)
                            Column.ReadOnly = False
                            Column.Unique = False
                            TextFileTable.Columns.Add(Column)
                        Next
                        totalColumns = UpperBound
                    End If
                    Row = TextFileTable.NewRow
                    If RowCounter > 0 Then
                        Row(0) = (-1).ToString
                        For ColumnCount = 0 To UpperBound
                            Row(ColumnNames(ColumnCount)) = CurrentRow(ColumnCount).ToString
                        Next
                        TextFileTable.Rows.Add(Row)
                    End If
                End If
                RowCounter = RowCounter + 1
            Catch ex As  _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message & _
                "is not valid and will be skipped.")
            End Try
        End While

        TextFileReader.Dispose()
        DataGridView1.DataSource = TextFileTable
        Me._cursorPos = 0
        txtTotalRows.Text = TextFileTable.Rows.Count.ToString()
        txtCurrentPos.Text = Me._cursorPos
        Me.updated = False
        Me.saved = False
        txtCurrentPos.Text = "1"
        btnTryNext.Enabled = True
        btnTryAll.Enabled = True
        btnSaveOutput.Enabled = False
    End Sub

    Private Function FixString(ByVal strIn As String) As String
        Dim val As String
        val = " "
        If Not strIn.Equals("") Then
            val = strIn
        End If
        Return val
    End Function

    Private Function FixRelationship(ByVal strIn As String) As String
        Dim val As String
        val = "M"
        If Not strIn.Equals("") Then
            val = strIn
        End If
        Return val
    End Function

    Private Function RowAsJObject(ByVal Row As DataRow)

        Dim data As JObject
        Dim benefGroup As JObject

        data = New JObject()
        benefGroup = New JObject()

        benefGroup.Add("id", Row("beneficiaryGroup.id").ToString())
        data.Add("beneficiaryGroup", benefGroup)

        data.Add("birthDate", Row("birthDate").ToString())
        data.Add("comment", Row("comment").ToString())
        data.Add("documentId", Row("documentId").ToString())
        data.Add("firstName", Row("firstName").ToString())
        data.Add("lastName", Row("lastName").ToString())
        data.Add("gender", Row("gender").ToString())
        data.Add("delegateDocumentId", FixString(Row("delegateDocumentId").ToString()))
        data.Add("delegateFirstName", FixString(Row("delegateFirstName").ToString()))
        data.Add("delegateLastName", FixString(Row("delegateLastName").ToString()))
        data.Add("delegateRelationship", FixRelationship(Row("delegateRelationship").ToString()))
        data.Add("registrationDate", Row("registrationDate").ToString())
        data.Add("version", 2)
        data.Add("deleted", False)

        Return data
    End Function

    Private Sub btnTryNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTryNext.Click
        Dim newId As Int32

        If Me._cursorPos < TextFileTable.Rows.Count Then
            txtCurrentPos.Text = (Me._cursorPos + 1).ToString()
            If TextFileTable.Rows(Me._cursorPos)("MAPSId") = -1 Then
                newId = api.AddBeneficiary(RowAsJObject(TextFileTable.Rows(Me._cursorPos)))
                If newId > 0 Then
                    TextFileTable.Rows(Me._cursorPos)("MAPSId") = newId
                    Me.updated = Me.updated Or True
                End If
            End If
            Me._cursorPos = Me._cursorPos + 1
        End If
        If Me._cursorPos = TextFileTable.Rows.Count Then
            btnTryNext.Enabled = False
            btnTryAll.Enabled = False
        End If
        btnSaveOutput.Enabled = Me.updated
    End Sub

    Private Sub btnSaveOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOutput.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        System.IO.File.Create(SaveFileDialog1.FileName).Dispose()
        Dim csvWriter As New System.IO.StreamWriter(SaveFileDialog1.FileName)
        ' Dump column headers in new File
        For ColumnIdx = 0 To Me.totalColumns
            If ColumnIdx > 0 Then
                csvWriter.Write(",")
            End If
            csvWriter.Write(ColumnNames(ColumnIdx))
        Next
        csvWriter.Write(Environment.NewLine)

        For Each Row In TextFileTable.Rows
            For ColumnIdx = 0 To Me.totalColumns
                If ColumnIdx > 0 Then
                    csvWriter.Write(",")
                End If
                csvWriter.Write(Row(ColumnIdx).ToString())
            Next
            csvWriter.Write(Environment.NewLine)
        Next
        csvWriter.Close()
        Me.saved = True
        btnSaveOutput.Enabled = False
    End Sub

    Private Sub btnTryAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTryAll.Click
        Dim Row As DataRow
        Dim newId As Int32
        Dim hasBeenUpdated As Boolean
        hasBeenUpdated = False

        For Each Row In TextFileTable.Rows
            newId = -1
            If Row("MAPSId") = -1 Then
                newId = api.AddBeneficiary(RowAsJObject(Row))
                If newId > 0 Then
                    TextFileTable.Rows(Me._cursorPos)("MAPSId") = newId
                    hasBeenUpdated = hasBeenUpdated Or True
                    Me._cursorPos = Me._cursorPos + 1
                End If
            End If
        Next
        Me.updated = hasBeenUpdated
        btnSaveOutput.Enabled = Me.updated
        btnTryNext.Enabled = False
        btnTryAll.Enabled = False
    End Sub

    Private Sub DataLoader_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Me.updated And Not Me.saved) Then
            If MsgBox("Existen datos sin guardar: ¿Está seguro de continuar? (Perderá sus datos)", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Application.Exit()
            End If
            e.Cancel = True
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateNext.Click
        Dim newId As Int32
        Dim data As JObject

        If Me._cursorPos < TextFileTable.Rows.Count Then
            txtCurrentPos.Text = (Me._cursorPos + 1).ToString()

            data = RowAsJObject(TextFileTable.Rows(Me._cursorPos))
            data.Add("id", TextFileTable.Rows(Me._cursorPos)("MAPSId").ToString())
            newId = api.UpdateBeneficiary(data)
            If newId > 0 Then
                TextFileTable.Rows(Me._cursorPos)("MAPSId") = newId
                Me.updated = Me.updated Or True
            End If

            Me._cursorPos = Me._cursorPos + 1
        End If
        If Me._cursorPos = TextFileTable.Rows.Count Then
            btnTryNext.Enabled = False
            btnTryAll.Enabled = False
        End If
        btnSaveOutput.Enabled = Me.updated
    End Sub
End Class