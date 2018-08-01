// userData contiene los datos del usuario actual.
var userData = {
  "id": 1,
  "firstname":"Isabella",
  "lastName": "Salamanca",
  "email" : "isabella@salamanca.com",
  "role": "Health Worker"
};
/* Otros ejemplos:
// Tienda
var userData = {
  "id": 1,
  "firstname":"TIENDA",
  "lastName": "UNO",
  "email" : "tienda1@maps.org",
  "role": "Health Worker"
};
// Monitor de campo
var userData = {
  "id": 1,
  "firstname":"TIENDA",
  "lastName": "UNO",
  "email" : "tienda1@maps.org",
  "role": "Field Monitor"
};
 */

var beneficiaryData = {
  "info" : {
    "beneficiary_id": 65789641025451,
    "birth_date": "1992-05-22",
    "expiration_date": null,
    "registration_date": "2015-04-02",
    "gender": 1,
    "id_document": "45547150048948541",
    "name": "Villatoro",
    "first_name": "Claudia",
    "group_id": 2,
    "nutrimiles_id": "6578964102545",
    "version": 1
    },
  "events" :
    [ 
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 2,
          "higt" : 90,
          "soca" : 70,
          "soct" : 70
        },
        "validated": true
      } /*
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 1
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 1,
          "higa" : 80
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 1,
          "higa" : 80,
          "higt" : 90
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 1,
          "higa" : 80,
          "higt" : 90,
          "soca" : 70
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 1,
          "higa" : 80,
          "higt" : 90,
          "soca" : 70,
          "soct" : 80
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 2,
          "higa" : 80,
          "higt" : 90,
          "soca" : 70,
          "soct" : 80
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 3,
          "higa" : 80,
          "higt" : 90,
          "soca" : 70,
          "soct" : 80
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 4,
          "higa" : 80,
          "higt" : 90,
          "soca" : 70,
          "soct" : 80
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 4,
          "huea" : 80
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 4,
          "huea" : 80,
          "huet" : 70
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 5,
          "higa" : 80,
          "higt" : 90,
          "soca" : 70,
          "soct" : 80
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 6,
          "huea" : 80,
          "huet" : 70
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 6,
          "huea" : 80,
          "huet" : 70,
          "basa" : 90,
        },
        "validated": true
      },
      {
        "type": 1,
        "userID": 1,
        "date": "2016-11-15T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "asis" : 6,
          "huea" : 80,
          "huet" : 70,
          "basa" : 90,
          "bast" : 95
        },
        "validated": true
      } */
    ]
};