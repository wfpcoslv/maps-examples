/*
 * English language definition for MAPS.
 * To 
 */
var lang_en = new Language();

// Default definitions for english lang_enuage:
lang_en.default_alert =      "Something wrong happened. Contact provider"
lang_en.ok =                 "OK"
lang_en.cancel =             "Cancel"
lang_en.weight =             "Weight"
lang_en.in_weight =          "in Kg"
lang_en.length =             "Length"
lang_en.in_length =          "in cm"
lang_en.lenght =             "Length"
lang_en.in_lenght =          "in cm"
lang_en.height =             "Height"
lang_en.in_height =          "in cm"
lang_en.circum =             "Head circumference"
lang_en.in_circum =          "in cm"
lang_en.add_entry =          "Add entry"
lang_en.gest_age =           "Gestational age"
lang_en.in_gest_age =        "in weeks"
lang_en.intra_growth =       "Intrauterine growth"
lang_en.in_intra_growth =    "in cm"
lang_en.visit_date =         "Visit date"
lang_en.age_days =           "Age in days"
lang_en.nutritional_status = "Nutritional status"
lang_en.scp_given =          "SCP given"
lang_en.in_scp =             "units"
lang_en.is_allowed_to_get =  "This beneficiary is allowed to get "
lang_en.units_csp =          " units of CSP"
lang_en.not_allowed =        "This beneficiary is not allowed to get more SCP"
lang_en.age =                "Age"
lang_en.gestationalAge =     "Gestational age"
lang_en.intrauterineGrowth = "Intrauterine growth"
lang_en.headCircumference =  "Head circumference"
lang_en.scpReceived =        "SCP given"
lang_en.nextVisit =          "Next visit"
lang_en.gaveBirth =          "Gave birth"
lang_en.childDeath =         "Child Death"
lang_en.deinf =              "Early Development Stimulation"
lang_en.alimsal =            "Healthy Food Intake"
lang_en.habvid =             "Livelihood activities"

lang_en.YES_NO = [
    { 'v': 1, t: "Yes"},
    { 'v': 2, t: "No"}
  ];

lang_en.options = [
  { 'name': 'deinf', 'options': lang_en.YES_NO },
  { 'name': 'alimsal', 'options': lang_en.YES_NO },
  { 'name': 'habvid', 'options': lang_en.YES_NO }
];

lang = lang_en; // Override default language instance