// Requires lang.js
var lang_es = new Language();
lang_es.default_alert =      "Algo malo ha sucedido, contacte al proveedor."
lang_es.ok =                 "OK"
lang_es.cancel =             "Cancelar"
lang_es.weight =             "Peso"
lang_es.in_weight =          "en Kg"
lang_es.lenght =             "Longitud"
lang_es.in_lenght =          "en cm"
lang_es.length =             "Longitud"
lang_es.in_length =          "en cm"
lang_es.height =             "Talla"
lang_es.in_height =          "en cm"
lang_es.circum =             "Circunferencia craneana"
lang_es.in_circum =          "en cm"
lang_es.add_entry =          "Guardar en tarjeta"
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
// Para captura de coresponsabilidad:
lang_es.tiponac =            "Tipo de nacimiento:"
lang_es.esquemavac =         "Esquema de vacunación según edad:"
lang_es.vita =               "Micronutritentes: Vitamina A"
lang_es.vitsf =              "Micronutrientes: Sulfato Ferroso"
lang_es.antipar =            "Antiparasitarios: Mebandazole"
lang_es.anemia =             "Respuesta de examen Hemoglobina"
lang_es.antitetanica =       "Vacunación Antitetánica"
lang_es.influenza =          "Vacunación Influenza Estacional"
lang_es.ggh =                "Vacunación con Gamma Globulina hiperinmune"
lang_es.enrn =               "Estado Nutricional del RN"
lang_es.folico =             "Ácido Fólico"
lang_es.hierro =             "Hierro"
lang_es.calcio =             "Calcio"
lang_es.lactan =             "Lactancia Materna"
lang_es.seq =                "Secuencia de visita"
lang_es.emboff =             "Edad gestacional"
lang_es.peso =               "Peso (kg)"
lang_es.talla =              "Talla (cm)"
lang_es.edadias =            "Edad"

// Opciones de selección comunes
lang_es.SI_NO = [
    { 'v': 1, 't': "Sí"},
    { 'v': 2, 't': "No"}
  ];
lang_es.SI_NO_OTROS = [
    { 'v': 1, 't': "Sí"},
    { 'v': 2, 't': "No (No hay)"},
    { 'v': 3, 't': "No (No lo toma)"},
    { 'v': 4, 't': "No (Otro)"}
];
lang_es.TIPO_NAC = [
    { 'v': 1, 't': "Intrahospitalario"},
    { 'v': 2, 't': "Intradomiciliar"}
];
lang_es.RSP_HEMOGLOB = [
    { 'v': 1, 't': "Hay Anemia"},
    { 'v': 2, 't': "No hay Anemia"},
    { 'v': 9, 't': "No se realizó el exámen"},
];
lang_es.RSP_ENRN = [
    { 'v': 1, 't': "Bajo peso"},
    { 'v': 2, 't': "Normal"},
    { 'v': 3, 't': "Arriba de lo normal"},
];

// Asignación de listas de selección
lang_es.options = [
  { 'name': 'deinf', 'options': lang_es.SI_NO },
  { 'name': 'alimsal', 'options': lang_es.SI_NO },
  { 'name': 'habvid', 'options': lang_es.SI_NO },
  { 'name': 'tiponac', 'options': lang_es.TIPO_NAC },
  { 'name': 'esquemavac', 'options': lang_es.SI_NO },
  { 'name': 'vita', 'options': lang_es.SI_NO_OTROS },
  { 'name': 'vitsf', 'options': lang_es.SI_NO_OTROS },
  { 'name': 'antipar', 'options': lang_es.SI_NO_OTROS },
  { 'name': 'anemia', 'options': lang_es.RSP_HEMOGLOB },
  { 'name': 'antitetanica', 'options': lang_es.SI_NO },
  { 'name': 'influenza', 'options': lang_es.SI_NO },
  { 'name': 'ggh', 'options': lang_es.SI_NO },
  { 'name': 'enrn', 'options': lang_es.RSP_ENRN },
  { 'name': 'folico', 'options': lang_es.SI_NO_OTROS },
  { 'name': 'hierro', 'options': lang_es.SI_NO_OTROS },
  { 'name': 'calcio', 'options': lang_es.SI_NO_OTROS },
  { 'name': 'lactan', 'options': lang_es.SI_NO_OTROS }
];

lang = lang_es;