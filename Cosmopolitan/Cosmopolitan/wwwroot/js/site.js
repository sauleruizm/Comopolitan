﻿// Write your Javascript code.

var model = {
    PrecioDeVenta:          ko.observable(0),
    Financiamiento:         ko.observable(0),
    AbonoInicialCalculado:  ko.observable( 0),
    AbonoInicialIngresado:  ko.observable( 0),
    MontoAFinanciar:        ko.observable(0),
    TaseDeInteres:          ko.observable(0),
    TaseDeInteresDinero:    ko.observable(0),
    Plazo:                  ko.observable(0),
    Capital: ko.observable(0),
    CapitalFeci: ko.observable(0),
    Mensualidad: ko.observable(0),
    MensualidadConFeci: ko.observable(0)
};

$(function () {
    ko.applyBindings(model);
});

function calcular() {

    $.getJSON("/calcular", model,
        function (data, textStatus, jqXHR) {
            model = data;
        }
    );

}