$(document).ready(function () {
    $('#ValorCaptcha').val('');

    $('#frmRecuperarCodigo').submit(function () {
        return $('#frmRecuperarCodigo').valid();
    });

    $('#frmRecuperarCodigo').validate({
        errorElement: 'div', errorClass: 'error', focusInvalid: true,
        rules: {
            CorreoElectronico: { required: true },
            ValorCaptcha: { required: true }
        },
        messages: {
            CorreoElectronico: { required: '&nbsp;Campo requerido' },
            ValorCaptcha: { required: '&nbsp;Campo requerido' }
        }
    });
});