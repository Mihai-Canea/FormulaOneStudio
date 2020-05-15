"use strict"

var table, card;

$(document).ready(function () {
    var app = new Vue({
        el: '#wrapper',
        data: function () {
            return {
                circuits: [],
                driversTable: [],
            }
        },
        methods: {
            ShowCircuits: function () {
                var uri = '../api/circuits';
                var myData;
                $.getJSON(uri)
                    .done((data) => {
                        this.circuits = data;
                        //console.log(data)
                    });
            }
        },
    });

    app.ShowCircuits();
});