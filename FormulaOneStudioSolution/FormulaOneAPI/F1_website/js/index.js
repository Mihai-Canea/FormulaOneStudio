"use strict"

var table, card;

$(document).ready(function () {

    var app = new Vue({
        el: '#wrapper',
        data: function () {
            return {
                drivers: [],
                driversTable: [],
                driverDetail: [],
                pos: 0,
                totalScore: 0,
                grandPrix: 0,
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
            },
            ShowDriverScore: function (driverId) {
                var uri = `../api/drivers/${driverId}/score`;
                $.getJSON(uri)
                    .done((data) => {
                        this.totalScore = data;
                    });
            },
            ShowDriverGrandPrix: function (driverId) {
                var uri = `../api/drivers/${driverId}/grandprix`;
                $.getJSON(uri)
                    .done((data) => {
                        this.grandPrix = data;
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