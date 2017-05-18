var router = require('express').Router()
var bodyParser = require('body-parser');
var flash = require('express-flash')
var repo = require('./repo')

var Product = require('../models/product')
var productService = {
    getProduct
}

function getProduct(data, done) {
    repo.getProduct(data, (err, products) => {
        if (err) {
            done(err)
        }
        done(null, products)
    })
}

module.exports = productService