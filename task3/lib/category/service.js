var router = require('express').Router()
var bodyParser = require('body-parser');
var flash = require('express-flash')
var repo = require('./repo')

var Category = require('../models/category')
var categoryService = {
    addCategory
}

function addCategory(data, done) {
    repo.addCategory(data, (err) => {
        if (err) {
            done(err)
        }
        done()
    })
}

module.exports = categoryService