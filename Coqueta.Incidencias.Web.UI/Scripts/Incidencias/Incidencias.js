//Load Data in Table when document is ready
$(document).ready(function () {
    debugger;
    cargarFiltrosLotes();
});

//Load data function
function cargarFiltrosLotes() {
    debugger;
    AjaxCallJson("/Incidencias/ObtenerLotes", {}, CallBackCargarFiltros)
}

function CallBackCargarFiltros(data) {
    debugger;
    var option;

    $.each(data, function (index, tipo) {
        debugger;
        option += "<option value='" + tipo.Lotes + "'>" + tipo.Lotes +  "</option>";
    });
    $("#cboLotesMontado").html(option);
}