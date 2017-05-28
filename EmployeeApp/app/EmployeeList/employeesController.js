
/// <reference path="../app.js"/>
employeesApp.controller("employeesController", function ($scope,$log, apiService) {
    loadEmployees();

    //Function to load all Employee records
    function loadEmployees() {
        var promiseGet = apiService.get("Employees"); //The MEthod Call from service

        promiseGet.then(function (responce) {
            $scope.Employees = responce.data;
        },
            function (errorResponce) {
                $log.error('failure loading Employees', errorResponce);
            });
    }

    // remove existing user
    $scope.removeUser = function (id) {
        var deleteUser = apiService.delete(id);

        deleteUser.then(function (responce) {
            
            loadEmployees();
        },
            function (errorResponce) {
                $log.error('failure delete Employee', errorResponce);
            });
    }
});

