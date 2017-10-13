var app = angular.module("Homeapp", []);
app.controller("HomeController", function ($scope, $http) {
    $scope.btntext = "save";
    $scope.savedata = function () {
        $scope.btntext = "Please Wiat.....!";
        $http({
            method: 'POST',
            url: '/Home/Register',
            data: $scope.Registeration
        }).then(function (success) {
            $scope.Registeration = null;
            $scope.btntext = "save";
            alert(success.data);
            }, function (error) {
                alert(error.data);
            $scope.btntext = "save";

        });

       }
});