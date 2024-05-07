(function () {
    "use strict";

    function Controller(myService) {

        var vm = this;
        vm.buttonState = "init";

        vm.clickButton = clickButton;

        function clickButton() {

            vm.buttonState = "busy";

            myService.clickButton().then(function () {
                vm.buttonState = "success";
            }, function () {
                vm.buttonState = "error";
            });

        }
    }

    angular.module("umbraco").controller("TopicDashboardController", Controller);

})();