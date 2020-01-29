$(document).ready(function () {

    $('#divConfirmacionSms').hide();
    $('#divConfirmacionCorreo').hide();
    $('#btnSiguiente').attr('disabled', true);

    $('#MedioEntregaSms').on('change', function () {
        $('#divConfirmacionSms').show();
        $('#divConfirmacionCorreo').hide();
        $('#btnSiguiente').attr('disabled', false);
    });

    $('#MedioEntregaCorreo').on('change', function () {
        $('#divConfirmacionSms').hide();
        $('#divConfirmacionCorreo').show();
        $('#btnSiguiente').attr('disabled', false);
    });

    $('#frmEnviarCodigo').submit(function () {
        if ($("#MedioEntregaCorreo").is(':checked')) {
            $('#ConfirmacionMedioEntrega').val($('#ConfirmacionCorreo').val())
        }
        else {
            $('#ConfirmacionMedioEntrega').val($('#ConfirmacionSms').val())
        }
        return $('#frmEnviarCodigo').valid();
    });

    $('#frmEnviarCodigo').validate({
        errorElement: 'div', errorClass: 'error', focusInvalid: true,
        rules: {
            ConfirmacionCorreo: { required: true },
            ConfirmacionSms: { required: true }
        },
        messages: {
            ConfirmacionCorreo: { required: '&nbsp;Campo requerido' },
            ConfirmacionSms: { required: '&nbsp;Campo requerido' }
        }
    });
});