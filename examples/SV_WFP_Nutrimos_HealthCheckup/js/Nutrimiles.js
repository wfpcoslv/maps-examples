/*
 * Copyright (C) 2017 World Food Programme - All Rights Reserved.
 *
 * This file is part of "MAPS Co-responsibilities Examples".
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * Implementation examples originally written by Mario Gómez.
 * For more info about this examples contact at <mario.gomez@wfp.org>
 */

/*
 * Nutrimiles es una clase abstracta de alto nivel que facilita el 
 * acceso a la API NFC de bajo nivel para lectura y escritura de 
 * registros en las tarjetas MAPS.
 * Aunque las funciones de bajo nivel pueden ser accedidas fácilmente
 * directamente desde JavaScript se recomienda instanciar Nutrimiles
 * luego de la carga del archivo de HTML y utilizar las funciones
 * de ayuda.
 * La clase también incluye funciones "simuladas" para facilitar y
 * acelerar el desarrollo sin necesidad de contar con un dispositivo
 * FAMOCO.
 * En donde se encuentre la palabra "NATIVO" indica una llamada a la 
 * API NFC de bajo nivel. Para garantizar un buen desempeño se
 * recomienda reducir el número de llamadas de bajo nivel al mínimo.
 */
function Nutrimiles() {

  // Las siguientes funciones están descontinuadas, pueden no incluirse
  // en futuras versiones. Instancie esta clase y acceda a los datos
  // utilizando los métodos getBeneficiaryInformations(),
  // getTransactions() y getUserInformations()
  this.beneficiary = function() {
    return this.getBeneficiaryInformations();
  }
  this.events = function() {
    return this.getTransactions();
  }
  this.userInfos = function(){
    return this.getUserInformations();
  }
}

/** NATIVO
  * createTransaction ingresa una nueva transacción en el registro
  * cíclico de la tarjeta NFC. Recuerda que los eventos no pueden ser
  * modificados una vez escritos en la tarjeta.
  */
Nutrimiles.prototype.createTransaction = function(newEvent) {
  if((typeof NutrimilesAndroid !== 'undefined')&&(typeof NutrimilesAndroid.createTransaction !== 'undefined')) {
    return NutrimilesAndroid.createTransaction(JSON.stringify(newEvent));
  } else {
    console.log(JSON.stringify(newEvent));
  }
}

/** NATIVO
  * getUserInformations devuelve la información del usuario local
  * para esta implementación se devuelve un objeto con los siguientes
  * atributos:
  *   id: ID único de usuario en MAPS.
  *   firstname: Nombre de pila
  *   lastname: Apellido
  *   email: Nombre de usuario registrado en la plataforma.
  *     Por convención MAPS utiliza correos institucionales como nombre
  *     de usuario dentro de la plataforma
  *   role: Rol del usuario según definido en MAPS Cloud.
  */
Nutrimiles.prototype.getUserInformations = function() {
  if((typeof NutrimilesAndroid !== 'undefined')&&(typeof NutrimilesAndroid.getUserInformations !== 'undefined')) {
    return JSON.parse(NutrimilesAndroid.getUserInformations());
  } else {
    return user_info;
  }
}

/** NATIVO
  * getBeneficiaryInformations devuelve la información del beneficiario
  * que se encuentra almacenado en la tarjeta que corresponde a los
  * datos ingresados al momento de inicialización de la misma.
  * Se devuelven los siguientes atributos:
  *   beneficiary_id: ID único de usuario en MAPS. Nótese que este es
  *     un ID único dentro de la plataforma y no necesariamente coincide
  *     coincide con el ID definido como único para otras plataformas de
  *     registro de beneficiarios.
  *   birth_date: Fecha de Nacimiento
  *   expiration_date: Fecha de expiración de la tarjeta.
  *   registration_date: Fecha de inicialización de la tarjeta en la
  *     plataforma.
  *   gender: Sexo biológico (1:Mujer, 2:Hombre)
  *   id_document: Número de documento único de beneficiario.
  *   name: Apellido (BUG)
  *   first_name: Nombre de pila
  *   group_id: ID de grupo dentro de MAPS.
  *   nutrimiles_id: Número de identificación dentro del programa.
  *   version: Versión de la API NFC.
  */
Nutrimiles.prototype.getBeneficiaryInformations = function()  {
  if((typeof NutrimilesAndroid !== 'undefined')&&(typeof NutrimilesAndroid.getBeneficiaryInformations  !== 'undefined')) {
    // Return API Call if available
    return JSON.parse(NutrimilesAndroid.getBeneficiaryInformations());
  } else {
    return beneficiaryData.info;
  }
}

/** NATIVO
  * getTransactions es el método que devuelve el historial completo
  * de eventos en la tarjeta filtrados por tipo de co-responsabilidad
  * activa. Esta función devuelve tantas entradas como registros
  * almacenados en la tarjeta NFC.
  * Los valores devuelvos por este método se corresponden a los 
  * establecidos en la especificación de ProtocolBuffer
  */
Nutrimiles.prototype.getTransactions = function()  {
  if((typeof NutrimilesAndroid !== 'undefined')&&(typeof NutrimilesAndroid.getTransactions  !== 'undefined')) {
    // Return API Call if available
    return JSON.parse(NutrimilesAndroid.getTransactions());
  } else {
    return beneficiaryData.events;
  }
}

Nutrimiles.prototype.status = function() {
  //TODO: Return reader status.
  return 1; // On this test this always returns true.
}

Nutrimiles.prototype.prepareEvent = function(patientData) {
  // TODO: Implement validations
  return {
    'data' : patientData
  };
}

Nutrimiles.prototype.setBeneficiary = function(beneficiaryData) {
  // TODO: Implement validations
  this.beneficiary = beneficiaryData
}

Nutrimiles.prototype.setEvents = function(events) {
  // TODO: Implement validations
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

// Cambia el lenguaje de la interfaz al vuelo
function defineLanguage(language)
{
  lang = language
}

function calculateVisits(events) {
  var visits = 0;
  for (i=0;i<events.length;i++) {
    if(events[i].data.weight) {
      visits++;
    }
  }
  return visits;
}

function calculateRation(events) {
  var given_scp = 0;
  var allowed_scp = 0;
	for (i=0;i<events.length;i++) {
    if(events[i].data.scpReceived) {
      given_scp += events[i].data.scpReceived
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
