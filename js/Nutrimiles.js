// API Example.
// This requires beneficiary.js and input.js
function Nutrimiles() {
  this.beneficiary = {
  'group': BENEFICIARY_GROUP_ID,
  'birthDate': '2013-08-22T00:00:00.00Z',
  'age': BENEFICIARY_AGE,
  'sex': BENEFICIARY_SEX
  }
  
  this.userInfo = {
    'type': 1,
    'userID': 2,
    'deviceID': 112233
  }
  
  this.event = NUTRIMILES.event
}

Nutrimiles.prototype.status = function() {  // Returns 1 on valid reader status
  return 1; // On this test this always returns true.
}

Nutrimiles.prototype.prepareEvent = function(patientData) {
  // Prepare must validate the data
  return {
    'type': this.userInfo.type,
	  'userID': this.userInfo.userID,
	  'deviceID': this.userInfo.deviceID,
	  'patientData': patientData,
	  'validated': true
  }
}

Nutrimiles.prototype.pushEvent = function(event) {
  if(event.validated) {
    this.event.push(event)
    return true
  } else {
    return false
  }
}

Nutrimiles.prototype.submitJSON = function(newEvent, eventList) {
  // TODO: Do something with the data & the card?
  console.log(JSON.stringify(newEvent))
  console.log(JSON.stringify(eventList))
}