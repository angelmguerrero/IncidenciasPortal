//Load Data in Table when document is ready
$(document).ready(function () {
    cargarFiltrosLotes();
    cargarFiltrosIncidencias();

});

//Load data function
function cargarFiltrosLotes() {
    AjaxCallJson("/Incidencias/ObtenerLotes", {}, CallBackCargarFiltrosLotes)
}

function CallBackCargarFiltrosLotes(data) {
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
    debugger;
    $("#Item1_Semana").val(datos[0].NumSem);
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

function validate() {
    var isValid = true;
    if ($('#cboLotesMontado').val().trim() == "0") {
        $('#cboLotesMontado').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#cboLotesMontado').css('border-color', 'lightgrey');
    }
    if ($('#cboRiel').val().trim() == "0") {
        $('#cboRiel').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#cboRiel').css('border-color', 'lightgrey');
    }
    if ($('#cboTipoIncidencia').val().trim() == "0") {
        $('#cboTipoIncidencia').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#cboTipoIncidencia').css('border-color', 'lightgrey');
    }

    return isValid;
}


function GuardarIncidencia() {
    debugger;
    var res = validate();

    if (res == false) {
        return false;
    }

    var incObj = {
        Lote: $("#cboLotesMontado").val(),
        Riel: $("#cboRiel").val(),
        Semana: $("#Item1_Semana").val(),
        TipoIncidenciaId: $("#cboTipoIncidencia").val(),
        Descripcion: $("#Descripcion").val(),
    };

    AjaxCallJson("/Incidencias/AgregarIncidencia", {incObj} , CallBackGuardarOK)
}

function CallBackGuardarOK() {
    NotificacionRegistroGuardado();
}