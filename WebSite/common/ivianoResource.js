(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("ivianoResource", ["$resource", "appSettings", ivianoResource]);

    function ivianoResource($resource,appSettings) {
        return $resource(appSettings.serverPath + "/api/Ivianos/:id");
    };
}());