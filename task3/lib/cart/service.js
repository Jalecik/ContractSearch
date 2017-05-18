var router = require('express').Router()
var bodyParser = require('body-parser');
var flash = require('express-flash')
var repo = require('./repo')

var Cart = require('../models/cart')
var cartService = {
    getCart
}

function getCart(data, done) {
    repo.getCart(data, (err, data) => {
        if (err) {
            done(err)
        }
        done(null, data)
    })
}

module.exports = cartService