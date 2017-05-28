/// <reference path="../app.js"/>

employeesApp.controller("newEmployeeController", function ($scope,$log,$location,apiService) {
    loadJobTitles();

    //Function to load all job Titles records
    function loadJobTitles() {
        var getTitles = apiService.get("JobTitles"); //The MEthod Call from service

        getTitles.then(function (responce) {
            $scope.jobTitles = responce.data;
        },
            function (errorResponce) {
                $log.error('failure loading Job Titles', errorResponce);
            });
    }
    //Create new Employee
    
    $scope.saveEmployee = function (newEmployee) {

        var employee = {
            Name: $scope.firstName + " " + $scope.lastName,
            JobTitle: $scope.jobTitle.Title,
            EmployementDate: new Date($scope.employmentDate),
            Rate: $scope.rate
        };
        if (newEmployee.$valid) {
            var saveEmployee = apiService.post(employee);
            saveEmployee.then(function (responce) {
                $location.path('/');
            }, function (errorResponce) {
                $log.error('failed to add Employee', errorResponce);
                });
        } else {
            $log.error('model not valid');
        }

    };

});