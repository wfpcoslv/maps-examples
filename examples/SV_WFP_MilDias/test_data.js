// userData contiene los datos del usuario actual.
var userData = {
  "id": 1,
  "firstname":"MONITOR",
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
  "firstname":"MONITOR",
  "lastName": "UNO",
  "email" : "tienda1@maps.org",
  "role": "Field Monitor"
};
 */

var beneficiaryData = {
  "info" : {
    "beneficiary_id": 65789641025451,
    "birth_date": "2016-09-20",
    "expiration_date": null,
    "registration_date": "2015-01-02",
    "gender": 2,
    "id_document": "45547150048948541",
    "name": "Villatoro",
    "first_name": "Claudia",
    "group_id": 3,
    "nutrimiles_id": "6578964102545",
    "version": 1
    },
  "events" :
    [
      {
        "type": 1,
        "userID": 1,
        "date": "2017-09-20T13:33:40.919Z",
        "deviceID": 112233,
        "location": {
          "latitude": 1,
          "longitude": 1
        },
        "data": {
          "training": 1,
          "gaveBirth" : 1,
          "childDeath" : 1,
	  "preg_offset" : 1
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
          "weight": 3.7,
          "height": 52,
          "age": 16,
          "gestationalAge" : 23,
          "intrauterineGrowth" : 10,
          "headCircumference" : 20,
          "length" : 52,
          "scpReceived" : 0,
          "nextVisit" : "2017-01-01"
        },
        "validated": true
      }, {
        "type": 1,
        "userID": 2,
        "date": "2016-11-15T13:33:40.926Z",
        "deviceID": 112233,
        "location": {
          "latitude": 2,
          "longitude": 2
        },
        "data": {
          "weight": 7.0,
          "height": 56,
          "age": 111,
          "gestationalAge" : 23,
          "intrauterineGrowth" : 10,
          "headCircumference" : 20,
          "length" : 56,
          "scpReceived" : 0,
          "nextVisit" : "2017-01-01"
        },
        "validated": true
      }, {
        "type": 1,
        "userID": 2,
        "date": "2016-11-19T13:33:40.926Z",
        "deviceID": 112233,
        "location": {
          "latitude": 2,
          "longitude": 2
        },
        "data": {
          "weight": 0,
          "age": 0,
          "height": 0,
          "headCircumference" : 0,
          "gestationalAge" : 0,
          "intrauterineGrowth" : 0,
          "length" : 0,
          "scpReceived" : 5,
          "nextVisit" : "2017-01-01"
        },
        "validated": true
      }
    ]
};