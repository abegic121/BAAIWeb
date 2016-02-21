(function (app) {
    'use strict';

    app.controller('navbarController', ['$scope', function ($scope) {

        $scope.customer = {
            name: 'aldin',
            address: '1234 63rd st.'
        };

    }])
})(angular.module('baaiModule'));