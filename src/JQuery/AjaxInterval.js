$(document).ready(() => {
    setInterval(() => {
        $("#my-div").load('/dynamic.php')
    }, 15000);
});