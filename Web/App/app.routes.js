(function () {
    'use strict';

    angular.module('baaiModule', ['ngRoute']).config(function ($routeProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "app/components/home/index.html",
                controller: "homeController"
            })
            .when("/events", {
                templateUrl: "app/components/events/(some html file)",
                controller: ""
            })
            .when("/community", {
                templateUrl: "app/components/community/(some html file)",
                controller: ""
            })
            .when("/about", {
                templateUrl: "app/components/about/(some html file)",
                controller: ""
            }).otherwise({ redirectTo: "/" });
    })
});