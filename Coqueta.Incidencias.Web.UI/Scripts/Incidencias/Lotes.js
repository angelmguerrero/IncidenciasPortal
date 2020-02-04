//Load Data in Table when document is ready
$(document).ready(function () {
    loadData();
});

//Load data function
function loadData() {
    $.ajax({
        url: "/Incidencias/ObtenerLotes",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Lotes + '</td>';
                html += '<td>' + item.Estilo + '</td>';
                html += '<td>' + item.Combinacion + '</td>';
                html += '<td>' + item.Suela + '</td>';
                html += '<td>' + item.NumSem + '</td>';
                html += '<td><a href="#" onclick="return getbyID(' + item.Lotes + ')">Edit</a> | <a href="#" onclick="Delele(' + item.Lotes + ')">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
