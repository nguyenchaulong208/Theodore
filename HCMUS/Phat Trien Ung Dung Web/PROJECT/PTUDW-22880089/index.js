'use strict';
const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const expressHandlebars = require('express-handlebars');

// Cấu hình static files
app.use(express.static(__dirname + '/public'));

// Cấu hình express-handlebars
app.engine('hbs', expressHandlebars.engine({
    layoutsDir: __dirname + '/views/layouts',
    partialsDir: __dirname + '/views/partials',
    extname: 'hbs',
    defaultLayout: 'layout'
}));
app.set('view engine', 'hbs');
app.set('views', __dirname + '/views'); // Đảm bảo express biết thư mục views

// Tạo route cho trang chủ (home page)
app.get('/createTables', (req, res) => {
    let models = require('./models');
    models.sequelize.sync().then(() => {
        res.send('Table created!');
    });
}
);
app.get('/', (req, res) => {
    res.render('index', { 
    });
});
app.get('/:page', (req, res) => {
    res.render(req.params.page)});



// Khởi động server
app.listen(port, () => {
    console.log(`Server is running at http://localhost:${port}`);
});
