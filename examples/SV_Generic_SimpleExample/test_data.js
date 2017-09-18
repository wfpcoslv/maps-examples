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
          "data1" : 1,
          "data2" : 2
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
          "data1" : 1,
          "data2" : 2
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
          "data1" : 1,
          "data2" : 2
        },
        "validated": true
      }
    ]
};