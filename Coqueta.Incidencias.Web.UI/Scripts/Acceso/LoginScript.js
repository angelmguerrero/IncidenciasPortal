/*
$(document).ready(function () {
    $("#LoginBody").hide(0).delay(200).fadeIn(1000);
});*/

function get_KeyPress(textbox, evento) {
    //debugger;
    var keyCode;
    if (evento.which || evento.charCode) {
        keyCode = evento.which ? evento.which : evento.charCode;
        //return (keyCode != 13);
    }
    else if (window.event) {
        keyCode = event.keyCode;
        if (keyCode == 13) {
            if (event.keyCode)
                event.keyCode = 9;
        }
    }

    if (keyCode == 13) {
        entrar();
        return false;
    }
    return true;
}

function entrar() {

    var usuario = $("#txtUsuario").val();
    var password = $("#txtPassword").val();
    var mensaje = "";

    $("#wait").css("display", "block");
    
    if (checkInputs(usuario, password) === 1) {
        $("#wait").css("display", "none");
        alertify.alert('Notificación portal', 'Llenar los campos necesarios');
        $("#txtUsuario").css("border-color", "RED");
        $("#txtPassword").css("border-color", "RED");
        
    } else if (checkInputs(usuario, password) === 2) {
        $("#wait").css("display", "none");
        alertify.alert('Notificación portal', "El campo usuario esta vacio");
        $("#txtUsuario").css("border-color", "RED");

    } else if (checkInputs(usuario, password) === 3) {
        $("#wait").css("display", "none");
        alertify.alert('Notificación portal', "El campo password esta vacio");
        $("#txtPassword").css("border-color", "RED");

    } else {
        
        window.location.href = "/Login/Entrar";
        $("#wait").css("display", "none");
    }
}

function checkInputs(usuario, password) {
   var mensaje = 0;

   if (usuario === "" && password === "") {
       return 1;
   }else if(usuario === "") {
       return 2;
   } else if (password === "") {
       return 3;
   }else{
       return 0;
   }
   return mensaje;
}

function registro() {
    window.location.href = "/Login/Registro";
}
