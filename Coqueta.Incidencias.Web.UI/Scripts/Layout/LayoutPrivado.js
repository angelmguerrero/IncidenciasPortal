var linkPedido;
var url;

$(document).ready(function () {    
    ConfigurarCamposRequeridos();    
    if (passwordTemporal) {
        CambiarPassword(true);
    }
    ObtenerTotalMensajesSinLeer();
    ObtenerNotificacionBolsaCompra();
    ConfigurarTimeoutSesion();
});

function ConfigurarTimeoutSesion() {    
    $.jTimeout({
        flashTitle: true,
        flashTitleSpeed: 1000,
        flashingTitleText: 'Expiración de Sesión',
        originalTitle: document.title,     
        heartbeat: 1,        
        timeoutAfter: segundosTimeout,
        secondsPrior: 120,
        extendUrl: '/Acceso/ExtenderSesion',
        logoutUrl: '/Acceso/CerrarSesion',
        loginUrl: '/Acceso/CerrarSesion',
        onClickExtend: function (jTimeout) {
            location.reload(true);
        }
    });
}

function ObtenerTotalMensajesSinLeer() {
    AjaxCallJson('/Buzon/ObtenerTotalMensajesSinLeer', {}, CallbackObtenerTotalMensajesSinLeer);
}

function CallbackObtenerTotalMensajesSinLeer(data) {
    $('.totalMensajesBuzon').html(data);
    if (data == 0) {
        $('#divMensajesSinLeer').hide();
        $('#divSinMensajes').show();
        $('.totalMensajesBuzon').hide();
    }
    else {
        $('#divMensajesSinLeer').show();
        $('#divSinMensajes').hide();
        $('.totalMensajesBuzon').show();
    }
}

function ObtenerNotificacionBolsaCompra() {
    AjaxCallJson('/Pedido/ObtenerNotificacionElementosBolsa', {}, CallbackObtenerNotificacionBolsaCompra);
}

function CallbackObtenerNotificacionBolsaCompra(data) {
    if (data.Folio != "") {
        $('.totalCombinacionesPedido').html(data.ListaCombinaciones.length);
        $('#linkCapturaPedido').attr("href", obtenerUrlTipoPedido(data.TipoPedido))

        if (data.ListaCombinaciones.length == 0)
            $('#liCombinacionesPedido').hide();
        else
            $('#liCombinacionesPedido').show();
    }

    if (typeof ColocarFoco == 'function')
        ColocarFoco();
}

function obtenerUrlTipoPedido(tipoPedido) {
    
    switch (tipoPedido) {
        case 1:
            {             
                return "/Pedido/Disponible";
            }
        case 2:
            {             
                return "/Pedido/Programado";
            }
        case 3:
            {                
                return "/Pedido/TRAC";
            }
        default:
            {
                return null;
            }
    }
}

function ValidarPedidoExistente(tipoPedido) {
    AjaxCallJson('/Pedido/ValidarPedidoExistente', { tipoPedido: tipoPedido }, function (data) { CallbackValidarPedidoExistente(data, tipoPedido); });
};

function CallbackValidarPedidoExistente(data, tipoPedido) {

    var url = obtenerUrlTipoPedido(tipoPedido);
    if (data) {
        MostrarMensajeConfirmacion('Existe un pedido capturado, si cambia de pedido se guardara el actual como no completado. ¿Desea continuar?', function () {            
            LimpiarSesionPedido(true);        
            window.location = url;
        }, 'warning');
    }
    else {
        window.location = url;
    }
}

function LimpiarSesionPedido(noRecargarPantalla) {
    $("#tbodyp").html("");
    AjaxCallJson('/Pedido/LimpiarSesionPedido', {}, function () { if (!noRecargarPantalla) location.reload(); }, null);
}

function CambiarPassword(esPasswordTemporal) {
    AbrirModal('Actualizar Contraseña', '/Seguridad/CambiarPassword/', 'GET', 500);
    if (esPasswordTemporal) {
        $('#btnCancelar').hide();
        $('#btnCloseModal').hide();
    }
    else {
        $('#linkRightSidebar').click();
    }
}

function MostrarTerminosCondicionesUso() {
    AbrirModal('Términos y Condiciones de Uso', '/Legal/TerminosCondicionesUso/', 'GET', 950);
}

function MostrarAvisoPrivacidad() {
    AbrirModal('Aviso de Privacidad', '/Legal/AvisoPrivacidad/', 'GET', 950);
}