"use strict";

var fruits = ['Apple', 'Banana', 'Orange', 'Grape'];
var ul = $('#my-ul');
$.each(fruits, function (f) {
  $('<li/>').text(fruits[f]).appendTo(ul);
});