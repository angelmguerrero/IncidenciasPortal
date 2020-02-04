//Load Data in Table when document is ready
$(document).ready(function () {
    debugger;
    cargarFiltrosLotes();
    cargarFiltrosIncidencias();

});

//Load data function
function cargarFiltrosLotes() {
    AjaxCallJson("/Incidencias/ObtenerLotes", {}, CallBackCargarFiltros)
}

function CallBackCargarFiltros(data) {
    var option = "<option value='0'>--Seleccione un Lote--</option>";
    $.each(data, function (index, tipo) {
        option += "<option value='" + tipo.Lotes + "'>" + tipo.Lotes +  "</option>";
    });
    $("#cboLotesMontado").html(option);
}

function cargarFiltrosIncidencias() {
    AjaxCallJson("/Incidencias/ObtenerTipoIncidencias", {}, CallBackCargarFiltrosIncidencias, null)
}


function CallBackCargarFiltrosIncidencias(data) {
    var option = "<option value='0'>--Seleccionar Incidencia--</option>";
    $.each(data, function (index, tipo) {
        option += "<option value='" + tipo.Id + "'>" + tipo.Incidencia + "</option>";
    });
    $("#cboTipoIncidencia").html(option);
}




$("#cboLotesMontado").change(function () {
    var capturaId = this.value;
    if (capturaId != "0")
        AjaxCallJson("/Incidencias/ObtenerLotesDatos", { Id: capturaId }, CallbackObtenerDatosLotes, null);
    else
        LimpiarCaptura();
});


function CallbackObtenerDatosLotes(datos) {
    $("#Semana").val(datos[0].NumSem);
    $("#txtEstilo").val(datos[0].Estilo);
    $("#txtCombinacion").val(datos[0].Combinacion);
    $("#txtSuela").val(datos[0].Suela);

}

function LimpiarCaptura() {
    $("#Semana").val("");
    $("#txtEstilo").val("");
    $("#txtCombinacion").val("");
    $("#txtSuela").val("");
}
