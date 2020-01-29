AsyncLoad('https://www.googletagmanager.com/gtag/js?id=' + idGoogleAnalytics, function () {
    window.dataLayer = window.dataLayer || [];
    function gtag() { dataLayer.push(arguments); }
    gtag('js', new Date());
    gtag('config', idGoogleAnalytics);
});

function AsyncLoad(scriptURL, callback) {
    if (!scriptURL) { return; }
    var firstScriptTag = document.getElementsByTagName('script')[0];
    var js = document.createElement('script');
    js.type = 'text/javascript';
    js.src = scriptURL;
    js.async = true;

    if (callback && typeof (callback) === typeof (Function)) {
        if (js.addEventListener) {
            js.addEventListener('load', callback, false);
        }
        else {
            js.onreadystatechange = function () {
                if (js.readyState in { loaded: 1, complete: 1 }) {
                    js.onreadystatechange = null;
                    callback();
                }
            };
        }
    }

    firstScriptTag.parentNode.insertBefore(js, firstScriptTag);
}