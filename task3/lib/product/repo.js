var mongoose = require('mongoose')
var Product = require('../models/product')

var repo = {
  getProduct
}

function getProduct(categoryId, cb) {
  Product
    .find({ category: mongoose.Types.ObjectId(categoryId) })
    .populate('category')
    .exec(function (err, products) {
      cb(err, products)
    });
}

module.exports = repo

