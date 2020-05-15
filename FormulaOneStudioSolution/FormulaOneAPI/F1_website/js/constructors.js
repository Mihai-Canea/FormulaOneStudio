"use strict"

var table, card;

$(document).ready(function () {
    var app = new Vue({
        el: '#wrapper',
        data: function () {
            return {
                constructors: [],
            }
        },
        methods: {
            ShowConstructors: function () {
                var uri = '../api/constructors';
                var myData;
                $.getJSON(uri)
                    .done((data) => {
                        this.constructors = data;
                        //console.log(data)
                    });
            }
        },
    });

    app.ShowConstructors();
});