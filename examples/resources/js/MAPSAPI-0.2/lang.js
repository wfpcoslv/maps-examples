/*
 * This file contains the default language definition for the UI.
 * In Nutrimiles the UI is fully customizable, this file must be
 * included
 */
function Language() {
  this.options = Array();
};

Language.prototype.translate = function(text) {
  for(var name in this) {
    if(name == text)
      return this[name]
  }
  return text;
};

Language.prototype.listOption = function(listname, currval) {
  currval = ""+currval;
  for(var i in this.options) {
    if(this.options[i].name == listname) {
      for(var j in this.options[i].options) {
        if(this.options[i].options[j].v == currval) {
          return this.options[i].options[j].t;
        }
      }
    }
  }
  return currval;
};

var lang = new Language();