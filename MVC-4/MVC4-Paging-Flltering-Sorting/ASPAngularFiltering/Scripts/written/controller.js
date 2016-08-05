
var NgApp = angular.module('NgApp', ['ui.bootstrap']);
NgApp.controller('TodoController', function ($scope, $http) {
    $scope.filteredTodos = []
   , $scope.currentPage = 1
   , $scope.numPerPage = 10
   , $scope.maxSize = 5;

    $scope.makeTodos = function () {
        $scope.todos = [];
        $http({
            method: 'GET', // You can send or request a JSON file here
            url: '/APIService/SendEnployeeAsJson'  //Your requested api sending JSON data
        }).then(function successCallback(response) {
            $scope.todos = response.data;
        }, function errorCallback(response) {
        });
        
    };
    $scope.makeTodos();

    $scope.numPages = function () {
        return Math.ceil($scope.todos.length / $scope.numPerPage);
    };

    $scope.$watch('currentPage + numPerPage', function () {
        var begin = (($scope.currentPage - 1) * $scope.numPerPage), end = begin + $scope.numPerPage;
        $scope.filteredTodos = $scope.todos.slice(begin, end);
    });
});

