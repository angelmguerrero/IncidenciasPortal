﻿//Load Data in Table when document is ready
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
    $("#Descripcion").val("");
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

    if (jQuery('#FileUpload').val()) {
        $('#FileUpload').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#FileUpload').css('border-color', 'lightgrey');
    }

}


function GuardarIncidencia() {
    debugger;
    var res = validate();

    if (res == false) {
        return false;
    }

   
    // Checking whether FormData is available in browser
    if (window.FormData !== undefined) {

        var fileUpload = $("#FileUpload").get(0);
        var files = fileUpload.files;

        // Create FormData object
        var fileData = new FormData();
        fileData.append("Lote", $("#cboLotesMontado").val());
        fileData.append("Riel", $("#cboRiel").val());
        fileData.append("Semana", $("#Semana").val());
        fileData.append("TipoIncidenciaId", $("#cboTipoIncidencia").val());
        fileData.append("Descripcion", $("#Descripcion").val());


        // Looping over all files and add it to FormData object
        for (var i = 0; i < files.length; i++) {
            fileData.append(files[i].name, files[i]);
        }

        $.ajax({
            url: '/Incidencias/AgregarIncidencia',
            type: "POST",
            contentType: false, // Not to set any content header
            processData: false, // Not to process data
            data: fileData,
            success: function (result) {
                CallBackGuardarOK();
            },
            error: function (err) {
                alert(err.statusText);
            }
        });
    } else {
        alert("FormData is not supported.");
    }
}

function CallBackGuardarOK() {
    LimpiarCaptura();
    cargarFiltrosLotes();
    cargarFiltrosIncidencias();
    NotificacionRegistroGuardado();
    $("#cboRiel").val("0");
}


function show(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            $('#user_img').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}
