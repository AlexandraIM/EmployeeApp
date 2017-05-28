
/// <reference path="app.js"/>

employeesApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when('/', {
        templateUrl: '/app/EmployeeList/employees.html',
        controller: 'employeesController'
    }).when('/new', {
        templateUrl: '/app/EmployeeNewForm/newEmployee.html',
        controller: 'newEmployeeController'
    })
    .otherwise({
        redirectTo: '/'
    });
    $locationProvider.html5Mode(true);
});
