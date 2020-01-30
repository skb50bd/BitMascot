var fruits = ['Apple', 'Banana', 'Orange', 'Grape'];
var ul = $('#my-ul')
$.each(fruits, f => {
    $('<li/>').text(fruits[f]).appendTo(ul);
});