$(document).ready(function () {
    $('#CodigoSeguridad').val('');
    $('#spanLeyenda').text($('#hiddenLeyenda').val());

    $('#frmValidarCodigo').submit(function () {
        return $('#frmValidarCodigo').valid();
    });

    $('#frmValidarCodigo').validate({
        errorElement: 'div', errorClass: 'error', focusInvalid: true,
        rules: {
            CodigoSeguridad: { required: true }
        },
        messages: {
            CodigoSeguridad: { required: '&nbsp;Campo requerido' }
        }
    });
});