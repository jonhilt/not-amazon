const gulp = require('gulp');

gulp.task('css', () => {

    const devBuild = ((process.env.NODE_ENV || 'development').trim().toLowerCase() === 'development');

    const postcss = require('gulp-postcss');
    const purgecss = require('gulp-purgecss');

    let build = gulp.src('./Styles/site.css')
        .pipe(postcss([
            require('precss'),
            require('tailwindcss'),
            require('autoprefixer')
        ]));

    // build = build
    //     .pipe(purgecss({
    //             content: ['**/*.html', '**/*.razor'],
    //             defaultExtractor: content => content.match(/[\w-/:]+(?<!:)/g) || []
    //         }
    //     ));

    return build.pipe(gulp.dest('./wwwroot/css/'));
});