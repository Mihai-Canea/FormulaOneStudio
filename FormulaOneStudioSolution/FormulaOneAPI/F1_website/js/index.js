"use strict"

var table, card;

$(document).ready(function () {

    var app = new Vue({
        el: '#wrapper',
        data: function () {
            return {
                drivers: [],
                driversTable: [],
            }
        },
        methods: {
            ShowDrivers: function () {
                if ($('#selectedYear').text() == 'All')
                    $('#selectedYear').text('');
                var uri = '../api/' + $('#selectedYear').text() + '/drivers/';
                var myData;
                $.getJSON(uri)
                    .done((data) => {
                        //console.log("Drivers", myData)
                        this.drivers = data;
                        //console.log(this.drivers)
                    });
            }
        },
    });

    app.ShowDrivers();

    table = $("#tableDrivers");
    card = $("#cardDrivers");

    $('.dropdown-menu a').click(function () {
        $('#selectedYear').text($(this).text());
        app.ShowDrivers();
    });

});

function visualizza(n) {
    if (n == 0) {
        table.hide();
        card.show();
    }
    else if (n == 1) {
        table.show();
        card.hide();
    }
}