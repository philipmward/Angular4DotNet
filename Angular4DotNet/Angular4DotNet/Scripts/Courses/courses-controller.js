"use strict";

registrationModule.controller("RegistrationController", function ($scope, bootstrappedData) {
    $scope.courses = bootstrappedData.courses;
});