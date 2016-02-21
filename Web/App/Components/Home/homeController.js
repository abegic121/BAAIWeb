(function (app) {
    'use strict';

    app.controller('homeController', ['$scope', function ($scope) {

        $scope.view = {
            name: 'homeController',
        };

    }])
})(angular.module('baaiModule'));