var express = require('express')
var path = require('path')
var morgan = require('morgan')
var mongoose = require('mongoose')
var bodyParser = require('body-parser')
var session = require('express-session')
var cookieParser = require('cookie-parser')
var flash = require('express-flash')
var MongoStore = require('connect-mongo')(session)
// var passport = require('passport')

var secret = require('../config/index')


var app = express()

mongoose.connect(secret.database, function (err) {
    if (err) {
        console.log(err)
    } else {
        console.log("Connected to db")
    }
})

var categoryCtrl = require('./controllers/category')
var productCtrl = require('./controllers/product')
var cartCtrl = require('./controllers/cart')

var exhbs = require('express-handlebars')
var handlebars = exhbs.create({
    defaultLayout: 'main',
    partialsDir: [
        'shared/templates/',
        'views/partials/'
    ]
});

app.engine('handlebars', handlebars.engine);
app.set('view engine', 'handlebars');

function exposeTemplates(req, res, next) {
    hbs.getTemplates({
        cache: app.enabled('view cache'),
        precompiled: true
    }).then(function (templates) {
        var extRegex = new RegExp(hbs.extname + '$');
        templates = Object.keys(templates).map(function (name) {
            return {
                name: name.replace(extRegex, ''),
                template: templates[name]
            };
        });

        if (templates.length) {
            res.locals.templates = templates;
        }

        setImmediate(next);
    })
        .catch(next);
}

// Middleware
app.use(morgan('dev'))
app.use(bodyParser.json())
app.use(bodyParser.urlencoded({ extended: true }))
app.use(cookieParser())
app.use(session({
    resave : true,
    saveUninitialized : true,
    secret: secret.secretkey,
    store : new MongoStore({ url : secret.database , autoReconnect : true })
}))
app.use(flash())
// app.use(passport.initialize())
// app.use(passport.session())
app.use(function(req,res,next){
    res.locals.user = req.user
    next()
})


app.get('/', function(req,res,next){
    res.render('home')
})

app.get('/add-category', function(req,res,next){
    res.render('admin/add-category',{message : req.flash('success')})
})
app.post('/add-category',categoryCtrl.addCategory)
//app.post('/add-category',categoryCtrl.addCategory)

app.get('/product', function(req,res,next){
    res.render('partials/product',{message : req.flash('success')})
})
app.get('/product/:id',productCtrl.getProduct);

// app.get('/', function(req,res,next){
//     res.render('./product-main',{message : req.flash('success')})
// })
app.get('/products/:id',cartCtrl.getCart);

app.use(express.static('public/'));
var port = secret.port

app.listen(port, function (err) {
    if (err) throw err;
    console.log("Server is run port" + " " + port)
})