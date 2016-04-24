var gulp = require('gulp');
var concat = require('gulp-concat');
var connect = require('gulp-connect');
var uglify = require('gulp-uglify');
var fs = require('fs');
var _ = require('lodash');

var scripts = require('./app.scripts.json');

var source = {
    js: {
        main: [
            'src/Fizzbuzz.js'
            ],
        src: [
            'spec/FizbuzzSpec.js'
        ]
    }
};

var destinations = {
    js: 'build',
    styles: 'build'
};

gulp.task('build', function(){
    gulp.src(source.js.main)
        .pipe(concat('katas.js'))
        .pipe(gulp.dest(destinations.js));

    gulp.src(source.js.src)
        .pipe(concat('specs.js'))
        .pipe(gulp.dest(destinations.js));
});

gulp.task('watch', function(){
    gulp.watch(source.js.main, ['js']);
});

gulp.task('connect', function() {
    connect.server({
        port: 8888
    });
});

gulp.task('vendor', function(){
    _.forIn(scripts.chunks, function(chunkScripts, chunkName){
        var paths = [];
        chunkScripts.forEach(function(script){
            var scriptFileName = scripts.paths[script];

            if (!fs.existsSync(__dirname + '/' + scriptFileName)) {

                throw console.error('Required path doesn\'t exist: ' + __dirname + '/' + scriptFileName, script)
            }
            paths.push(scriptFileName);
        });
        gulp.src(paths)
            .pipe(concat(chunkName + '.js')).pipe(uglify())
            //.on('error', swallowError)
            .pipe(gulp.dest(destinations.js))
    });

    _.forIn(scripts.styles, function(chunkScripts, chunkName){
        var paths = [];
        chunkScripts.forEach(function(script){
            var scriptFileName = scripts.paths[script];

            if (!fs.existsSync(__dirname + '/' + scriptFileName)) {

                throw console.error('Required path doesn\'t exist: ' + __dirname + '/' + scriptFileName, script)
            }
            paths.push(scriptFileName);
        });
        gulp.src(paths)
            .pipe(concat(chunkName + '.css'))
            .pipe(concat('styles.css'))
            .pipe(gulp.dest(destinations.styles))
    })
});

gulp.task('prod', ['vendor', 'build']);
gulp.task('dev', ['vendor', 'build', 'watch', 'connect']);
gulp.task('default', ['dev']);
