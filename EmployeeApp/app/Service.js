
/// <reference path="app.js"/>

employeesApp.service("apiService", function ($http) {
    //get all employees or job titles
    this.get = function (route) {
        return $http.get("/api/" + route);
    };
    //create new Employee
    this.post = function (employee) {
        return $http.post("/api/Employees", employee);
    };
    //delete Employee
    this.delete = function (EmpNo) {
        var request = $http({
            method: "delete",
            url: "/api/Employees/" + EmpNo
        });
        return request;
    }
});

