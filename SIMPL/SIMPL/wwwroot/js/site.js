
﻿$(document).ready(function () {
    $('#example').DataTable();
});
$('#projectInformation').on('shown.bs.modal', function () {
});
$('#taskDetails').on('shown.bs.modal', function () {
});
﻿// Write your JavaScript code.
$(document).ready(function () {
    $('#example').DataTable();
});
$(document).ready(function () {
    var ho = document.getElementsByClassName(".sorting_1");
    ho.hover(function () {
        $(this).css("background-color", "yellow");
    });
});