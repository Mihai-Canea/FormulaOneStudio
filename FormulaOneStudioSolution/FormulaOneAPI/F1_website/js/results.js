"use strict"

var table, card;

$(document).ready(function () {
    var app = new Vue({
        el: '#wrapper',
        data: function () {
            return {
                results: [],
            }
        },
        methods: {
            ShowResults: function () {
                var uri = '../api/' + $('#selectedYear').text() + '/results/' + $('#selectedRace').text();
                var myData;
                $.getJSON(uri)
                    .done((data) => {
                        this.results = data;
                        //console.log(this.results)
                    });
            }
        },
    });

    $('#yearnav .dropdown-menu a').click(function () {
        $('#selectedYear').text($(this).text());
        app.ShowResults();
    });

    $('#racenav .dropdown-menu a').click(function () {
        $('#selectedRace').text($(this).text());
        app.ShowResults();
    });

    app.ShowResults();
});