<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataLoader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.btnLoadFile = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataSet1 = New System.Data.DataSet
        Me.btnTryNext = New System.Windows.Forms.Button
        Me.btnTryAll = New System.Windows.Forms.Button
        Me.btnSaveOutput = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalRows = New System.Windows.Forms.TextBox
        Me.txtCurrentPos = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Archivo:"
        '
        'txtFileName
        '
        Me.txtFileName.Enabled = False
        Me.txtFileName.Location = New System.Drawing.Point(64, 6)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(162, 20)
        Me.txtFileName.TabIndex = 2
        Me.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(232, 4)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFile.TabIndex = 3
        Me.btnLoadFile.Text = "Abrir CSV"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(724, 144)
        Me.DataGridView1.TabIndex = 6
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'btnTryNext
        '
        Me.btnTryNext.Enabled = False
        Me.btnTryNext.Location = New System.Drawing.Point(333, 4)
        Me.btnTryNext.Name = "btnTryNext"
        Me.btnTryNext.Size = New System.Drawing.Size(124, 23)
        Me.btnTryNext.TabIndex = 7
        Me.btnTryNext.Text = "Intentar siguiente"
        Me.btnTryNext.UseVisualStyleBackColor = True
        '
        'btnTryAll
        '
        Me.btnTryAll.Enabled = False
        Me.btnTryAll.Location = New System.Drawing.Point(463, 4)
        Me.btnTryAll.Name = "btnTryAll"
        Me.btnTryAll.Size = New System.Drawing.Size(124, 23)
        Me.btnTryAll.TabIndex = 8
        Me.btnTryAll.Text = "Intentar todos"
        Me.btnTryAll.UseVisualStyleBackColor = True
        '
        'btnSaveOutput
        '
        Me.btnSaveOutput.Enabled = False
        Me.btnSaveOutput.Location = New System.Drawing.Point(593, 4)
        Me.btnSaveOutput.Name = "btnSaveOutput"
        Me.btnSaveOutput.Size = New System.Drawing.Size(124, 23)
        Me.btnSaveOutput.TabIndex = 9
        Me.btnSaveOutput.Text = "Guardar Salida"
        Me.btnSaveOutput.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Posición actual:"
        '
        'txtTotalRows
        '
        Me.txtTotalRows.Enabled = False
        Me.txtTotalRows.Location = New System.Drawing.Point(64, 34)
        Me.txtTotalRows.Name = "txtTotalRows"
        Me.txtTotalRows.Size = New System.Drawing.Size(39, 20)
        Me.txtTotalRows.TabIndex = 12
        '
        'txtCurrentPos
        '
        Me.txtCurrentPos.Enabled = False
        Me.txtCurrentPos.Location = New System.Drawing.Point(187, 34)
        Me.txtCurrentPos.Name = "txtCurrentPos"
        Me.txtCurrentPos.Size = New System.Drawing.Size(39, 20)
        Me.txtCurrentPos.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Para reiniciar abra de nuevo el archivo. (No olvide guardar)"
        '
        'DataLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 204)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCurrentPos)
        Me.Controls.Add(Me.txtTotalRows)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveOutput)
        Me.Controls.Add(Me.btnTryAll)
        Me.Controls.Add(Me.btnTryNext)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(742, 242)
        Me.Name = "DataLoader"
        Me.Text = "Bulk Loading Tool for MAPS/SCOPE-CODA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadFile As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents btnTryNext As System.Windows.Forms.Button
    Friend WithEvents btnTryAll As System.Windows.Forms.Button
    Friend WithEvents btnSaveOutput As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRows As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentPos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
