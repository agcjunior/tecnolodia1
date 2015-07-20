(function () {
    "use strict";
    angular.module("tecnolodiaModule")
           .controller("ivianoCtrl", ["ivianoResource",ivianoCtrl]);

    function ivianoCtrl(ivianoResource) {
        var vm = this;

        ivianoResource.query(function (data) {
            vm.ivianos = data;
        });
    };
}());