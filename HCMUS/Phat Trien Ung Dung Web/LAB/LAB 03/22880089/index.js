const express = require('express');
const app = express();
const expressHbs = require('express-handlebars');
const expressHbsPaginate = require('express-handlebars-paginate');

const port = process.env.PORT || 3000;

app.use(express.static (__dirname + '/html'));

app.engine('hbs', 
    expressHbs.engine({
        layoutsDir: __dirname + '/views/layouts', 
        defaultLayout: 'layout',
        extname: 'hbs',
        runtimeOptions: {
            allowProtoPropertiesByDefault: true,
            allowProtoMethodsByDefault: true,
        },
        helpers: {
            createPagination: expressHbsPaginate.createPagination,
            formatDate: (date) => {
            return date.toLocaleDateString('en-US', {
                year: 'numeric',
                month: 'long',
                day: 'numeric',
            });
        }
        }
    })
);
app.set('view engine', 'hbs');

app.get('/', (req, res) => { res.redirect('/blogs'); });
app.use('/blogs', require('./routes/blogsRouter'));
app.use('/details.html', require('./routes/blogsRouter'));

app.get('/details.html', (req, res) => { res.render('details'); });
app.listen(port, () => {
  console.log(`Server is running on port ${port}`);
});
