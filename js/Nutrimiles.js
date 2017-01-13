/*
 * Nutrimiles is a wrapper to encapsulate the API functions
 * provided access and modify the data on the NFC cards.
 * The goal for later versions is to provide a simple framework
 * to define rules to record and validate co-responsibilities.
 * For this implementation most of the logic is defined on the
 * HTML View,
 */
function Nutrimiles() {

  // This attributes are now replaced
  // by the API calls wrapped on the
  // Nutrimiles object it's not supposed
  // to access this data directly.
  this.beneficiary = null
  this.userInfo = null
  this.event = []
  
}

Nutrimiles.prototype.createTransaction = function(newEvent) {
  if(typeof createTransaction !== 'undefined') {
    // Return API Call if available
    return createTransaction(newEvent);
  } else {
    //NutrimilesAndroid.createTransaction(newEvent);
    console.log(JSON.stringify(newEvent));
  }
}

Nutrimiles.prototype.getUserInformations = function() {
  if(typeof getUserInformations !== 'undefined') {
    // Return API Call if available
    return getUserInformations();
  } else {
    return {  
      "id": 1,
      "name":"Isabella",
      "lastName": "Salamanca",
      "email" : "isabella@salamanca.com",
      "expiration_date": "2019-01-01",
      "role": "Health worker"
      };
  }
}

Nutrimiles.prototype.getBeneficiaryInformations = function()  {
  if(typeof getBeneficiaryInformations  !== 'undefined') {
    // Return API Call if available
    return getBeneficiaryInformations();
  } else {
    return {
      "beneficiary_id": 65789641025451,
      "birth_date": "1992-05-22",
      "expiration_date": null,
      "registration_date": "2015-04-02",
      "gender": 1,
      "id_document": "45547150048948541",
      "name": "Villatoro",
      "first_name": "Claudia",
      "group_id": 1,
      "nutrimiles_id": "6578964102545",
      "version": 1
      };
  }
}

Nutrimiles.prototype.getTransactions = function()  {
  if(typeof getTransactions  !== 'undefined') {
    // Return API Call if available
    return getTransactions();
  } else {
    return [
    {
      "type": 1,
      "userID": 1,
      "validationDate": "2016-11-15T13:33:40.919Z",
      "deviceID": 112233,
      "location": {
        "latitude": 1,
        "longitude": 1
      },
      "patientData": {
        "weight": 3.7,
        "height": 52,
        "age": 16,
        "gestational_age" : 23,
        "intrauterine_growth" : 10,
        "head_circumference" : 20,
        "length" : 52,
        "scp_received" : 0,
      },
      "validated": true
    }, {
      "type": 1,
      "userID": 2,
      "validationDate": "2016-11-15T13:33:40.926Z",
      "deviceID": 112233,
      "location": {
        "latitude": 2,
        "longitude": 2
      },
      "patientData": {
        "weight": 7.0,
        "height": 56,
        "age": 111,
        "gestational_age" : 23,
        "intrauterine_growth" : 10,
        "head_circumference" : 20,
        "length" : 56,
        "scp_received" : 0,
      },
      "validated": true
    }, {
      "type": 1,
      "userID": 2,
      "validationDate": "2016-11-19T13:33:40.926Z",
      "deviceID": 112233,
      "location": {
        "latitude": 2,
        "longitude": 2
      },
      "patientData": {
        "weight": 0,
        "height": 0,
        "age": 0,
        "gestational_age" : 0,
        "intrauterine_growth" : 0,
        "head_circumference" : 0,
        "length" : 0,
        "scp_received" : 5,
      },
      "validated": true
    }];
  }
}

Nutrimiles.prototype.status = function() {  // Returns 1 on valid reader status
  return 1; // On this test this always returns true.
}

Nutrimiles.prototype.prepareEvent = function(patientData) {
  // Prepare must validate the data
  return {
    'data' : patientData
  };
}

Nutrimiles.prototype.setBeneficiary = function(beneficiaryData) {
  // Do some validation
  this.beneficiary = beneficiaryData
}

Nutrimiles.prototype.setEvents = function(events) {
  // Do some validation
  this.event = events
}

Nutrimiles.prototype.pushEvent = function(event) {
  if(event.validated) {
    this.event.push(event)
    return true
  } else {
    return false
  }
}

// Helper functions for the UI.
function defineLanguage(language)
{
  lang = language
}

function calculateVisits(events) {
  var visits = 0;
	for (i=0;i<events.length;i++) {
    if(events[i].patientData.weight != 0) {
      visits++;
    }
	}
	return visits;
}

function calculateRation(events) {
  var given_scp = 0;
  var allowed_scp = 0;
	for (i=0;i<events.length;i++) {
    if(events[i].patientData.weight == 0) {
      given_scp += events[i].patientData.scp_received
    } else {
      allowed_scp += 5; // User is allowed to get 5 units by visit
    }
	}
	return allowed_scp - given_scp;
}

function age_days(date_str) {
  var today = new Date();
  var birth_date = new Date(date_str);
  return Math.floor((today.getTime()-birth_date.getTime())/86400000);
}

function calculate_z_deviation(measurement, sd0, sd1) {
  var stdDev = sd1-sd0;
  return ((measurement-sd0)/stdDev).toFixed(2);
}

// TODO: Merge this two functions in one.
function find_z_deviation_length(data_array, measurement1, measurement2) {
  var i = 0
  while(measurement1>data_array[i].Length) {
    i++;
  }
  
  if(i!=0)
    i = i-1;
  
  var stdDev = data_array[i].SD1-data_array[i].SD0;
  return ((measurement2-data_array[i].SD0)/stdDev).toFixed(2);
}
function find_z_deviation_height(data_array, measurement1, measurement2) {
  var i = 0
  while(measurement1>data_array[i].Height) {
    i++;
  }
  
  if(i!=0)
    i = i-1;
  
  var stdDev = data_array[i].SD1-data_array[i].SD0;
  return ((measurement2-data_array[i].SD0)/stdDev).toFixed(2);
}
