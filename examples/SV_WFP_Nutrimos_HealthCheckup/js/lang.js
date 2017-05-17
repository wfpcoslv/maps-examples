/*
 * This file contains the default language definition for the UI.
 * In Nutrimiles the UI is fully customizable, this file must be
 * included
 */
function Language() {
  this.default_alert =      "Something wrong happened. Contact provider"
  this.ok =                 "OK"
  this.cancel =             "Cancel"
  this.weight =             "Weight"
  this.in_weight =          "in Kg"
  this.length =             "Length"
  this.in_length =          "in cm"
  this.lenght =             "Length"
  this.in_lenght =          "in cm"
  this.height =             "Height"
  this.in_height =          "in cm"
  this.circum =             "Head circumference"
  this.in_circum =          "in cm"
  this.add_entry =          "Add entry"
  this.gest_age =           "Gestational age"
  this.in_gest_age =        "in weeks"
  this.intra_growth =       "Intrauterine growth"
  this.in_intra_growth =    "in cm"
  this.visit_date =         "Visit date"
  this.age_days =           "Age in days"
  this.nutritional_status = "Nutritional status"
  this.scp_given =          "SCP given"
  this.in_scp =             "units"
  this.is_allowed_to_get =  "This beneficiary is allowed to get "
  this.units_csp =          " units of CSP"
  this.not_allowed =        "This beneficiary is not allowed to get more SCP"
  this.age =                "Age"
  this.gestationalAge =     "Gestational age"
  this.intrauterineGrowth = "Intrauterine growth"
  this.headCircumference =  "Head circumference"
  this.scpReceived =        "SCP given"
  this.nextVisit =          "Next visit"
  this.gaveBirth =          "Gave birth"
  this.childDeath =         "Child Death"
};

Language.prototype.translate = function(text) {
  for(var name in this) {
    if(name == text)
      return this[name]
  }
  return text;
};

var lang = new Language();
