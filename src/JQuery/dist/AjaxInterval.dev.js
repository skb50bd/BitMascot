"use strict";

$(document).ready(function () {
  setInterval(function () {
    $("#my-div").load('/dynamic.php');
  }, 15000);
});