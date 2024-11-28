'use strict';
const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const expressHandlebars = require('express-handlebars');
const {createStarList} = require('./controller/handlebarsHelper');

// Cấu hình static files
app.use(express.static(__dirname + '/public'));

// Cấu hình express-handlebars
app.engine('hbs', expressHandlebars.engine({
    layoutsDir: __dirname + '/views/layouts',
    partialsDir: __dirname + '/views/partials',
    extname: 'hbs',
    defaultLayout: 'layout',
    runtimeOptions: {
        allowProtoPropertiesByDefault: true,
        // allowProtoMethodsByDefault: true,
    },
    helpers: {createStarList}
}));
app.set('view engine', 'hbs');
app.set('views', __dirname + '/views'); // Đảm bảo express biết thư mục views
//Routes
app.use('/', require('./routes/indexRouter'));
app.use('/products', require('./routes/productsRouter'));

// Xu ly loi
app.use((req, res, next) => {
    res.status(404).render('error',{message:'File not found'});
});
app.use((error,req, res, next) => {
    console.log(error);
    res.status(500).render('error',{message:'Internal server error'});
});

// Khởi động server
app.listen(port, () => {
    console.log(`Server is running at http://localhost:${port}`);
});
