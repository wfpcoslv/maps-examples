// Requires lang.js
var lang_es = new Language();
lang_es.default_alert =  "Algo malo ha sucedido, contacte al proveedor."
lang_es.ok =             "OK"
lang_es.cancel =         "Cancelar"
lang_es.weight =         "Peso"
lang_es.in_weight =      "en Kg"
lang_es.lenght =         "Longitud"
lang_es.in_lenght =      "en cm"
lang_es.length =         "Longitud"
lang_es.in_length =      "en cm"
lang_es.height =         "Talla"
lang_es.in_height =      "en cm"
lang_es.circum =         "Circunferencia craneana"
lang_es.in_circum =      "en cm"
lang_es.add_entry =      "Guardar en tarjeta"
lang_es.gest_age =           "Edad gestacional"
lang_es.in_gest_age =        "en semanas"
lang_es.intra_growth =       "Crecimiento intrauterino"
lang_es.in_intra_growth =    "en cm"
lang_es.visit_date =         "Fecha de visita"
lang_es.age_days =           "Edad días a la visita"
lang_es.nutritional_status = "Estado nutricional"
lang_es.scp_given =          "SCP entregado"
lang_es.in_scp =             "unidades"
lang_es.is_allowed_to_get =  "Este beneficiario puede recibir "
lang_es.units_csp =          " unidades de CSP"
lang_es.not_allowed =         "Este beneficiario no puede recibir más super-cereal."
lang_es.age =                "Edad"
lang_es.gestationalAge =     "Edad Gestacional"
lang_es.intrauterineGrowth = "Crecimiento intrauterino"
lang_es.headCircumference =  "Circunferencia craneana"
lang_es.scpReceived =        "SCP entregado"
lang_es.nextVisit =          "Siguiente visita"
lang_es.gaveBirth =          "Dió a luz"
lang_es.childDeath =         "Muerte infantil"
lang_es.deinf =              "Estimulación del Desarrollo Infantíl"
lang_es.alimsal =            "Alimentación Saludable"
lang_es.habvid =             "Habilidades para la vida"

// Opciones de selección comunes
lang_es.SI_NO = [
    { 'v': 1, 't': "Sí"},
    { 'v': 2, 't': "No"}
  ];

// Asignación de listas de selección
lang_es.options = [
  { 'name': 'deinf', 'options': lang_es.SI_NO },
  { 'name': 'alimsal', 'options': lang_es.SI_NO },
  { 'name': 'habvid', 'options': lang_es.SI_NO }
];

lang = lang_es;