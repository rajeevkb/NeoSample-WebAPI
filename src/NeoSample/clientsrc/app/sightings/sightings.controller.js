(function() {
    'use strict';

    angular
        .module('app')
        .controller('Sightings', Sightings);

    Sightings.$inject = [];
    function Sightings() {
        var vm = this;
        vm.stuff = [];
        vm.title = 'Zoo Sightings';

        activate();

        function activate() {
            console.log('Activated Sightings');
        }
    }
})();
