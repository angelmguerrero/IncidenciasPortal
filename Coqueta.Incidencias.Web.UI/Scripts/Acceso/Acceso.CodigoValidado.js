$(document).ready(function () {

    $('#frmValidarCodigo').submit(function () {
        return $('#frmValidarCodigo').valid();
    });

    $('#frmValidarCodigo').validate({
        errorElement: 'div', errorClass: 'error', focusInvalid: true,
        rules: {
            Password: { required: true },
            ConfirmacionPassword: { ValidacionPassword: { required: true } }
        },
        messages: {
            Password: { required: '&nbsp;Campo requerido' }
        }
    });

    $.validator.addMethod('ValidacionPassword', function (value) {
        return $('#Password').val() == $('#ConfirmacionPassword').val();
    }, '&nbsp;Contraseña no es igual');
});