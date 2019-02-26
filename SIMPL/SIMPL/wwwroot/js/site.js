// Write your JavaScript code.
$(document).ready(function () {
    $('#example').DataTable();
});
$(document).ready(function () {
    var ho = document.getElementsByClassName(".sorting_1");
    ho.hover(function () {
        $(this).css("background-color", "yellow");
    });
});