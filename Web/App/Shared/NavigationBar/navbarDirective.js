(function (app) {
    'use strict';

    app.directive('navbarDirective', function () {
        return {
            restrict: 'E',
            templateUrl: '/App/Shared/NavigationBar/navbar.html'
        };
    });

})(angular.module('baaiModule'));