(function() {
    'use strict';

    angular
        .module('app')
        .controller('ZooManagement', ZooManagement);

    ZooManagement.$inject = [];
    function ZooManagement() {
        var vm = this;
        vm.stuff = [];
        vm.title = 'Zoo Management';

        activate();

        function activate() {
            console.log('Activated ZooManagement');
        }
    }
})();
