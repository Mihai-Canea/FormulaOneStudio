"use strict"

var table, card;

$(document).ready(function () {
    var app = new Vue({
        el: '#wrapper',
        data: function () {
            return {
                races: [],
                results:[],
                pos: 0,

            }
        },
        methods: {
            ShowRaces: function () {
                var uri = '../api/' + $('#selectedYear').text() + '/races';
                var myData;
                $.getJSON(uri)
                    .done((data) => {
                        this.races = data;
                        //console.log(data)
                    });
            },
            ShowRacesResults: function (year,round){
                var uri = '../api/' + year + '/results/' + round;
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
        app.ShowRaces();
    });

    app.ShowRaces();
    //app.ShowRacesResults(2019, 1);
});