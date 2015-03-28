var gulp = require('gulp');
var jshint = require('gulp-jshint');
var config = require('./gulp.config')();
var $ = require('gulp-load-plugins')({lazy: true});
var bower = require('gulp-bower');

gulp.task('bower', function() {
  return bower()
});

gulp.task('default', function() {
    // place code for your default task here
});

gulp.task('vet', function() {
    return gulp
        .src([
        './clientsrc/**/*js',
        './*.js'
    ])
    .pipe(jshint())
    .pipe(jshint.reporter('jshint-stylish', {verbose: true}));
});

gulp.task('wiredep', function() {
    var options = config.getWiredepDefaultOptions();
    var wiredep = require('wiredep').stream;
    
    return gulp
        .src(config.index) 
        .pipe(wiredep(options))
        .pipe($.inject(gulp.src(config.js)))
        .pipe(gulp.dest(config.client)); 
});



