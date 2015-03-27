module.exports = function(){
    var client = './clientsrc/';
    var clientApp =  client + 'app/';
    
    var config = {
        temp: './.tmp/',
        
        alljs: [
            './src/**/*.js',
            './*js'
        ],
        client: client,
        index: client + 'index.html',
        
        js: [
            clientApp + '**/*.module.js',
            clientApp + '**/*.js',
            '!' + clientApp + '**/*.spec.js'
        ],
        
        /**
         * Bower and NPM locations
         */
        bower: {
            json: require('./bower.json'),
            directory: './bower_components/',
            ignorePath: '../../'
        }
    };
    
    config.getWiredepDefaultOptions = function() {
        var options = {
            bowerJson: config.bower.json,
            directory: config.bower.directory,
            ignorePath: config.bower.ignorePath     
        };
    };

    return config;

};