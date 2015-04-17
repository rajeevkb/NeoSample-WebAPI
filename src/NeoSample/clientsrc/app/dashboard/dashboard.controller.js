(function() {
    'use strict';

    angular
        .module('app')
        .controller('Dashboard', Dashboard);

    Dashboard.$inject = [];
    function Dashboard() {
        var vm = this;
        vm.stuff = [];
        vm.title = 'Dashboard';

        activate();

        function activate() {
            console.log('Activated Dashboard');
        }
    }
})();
