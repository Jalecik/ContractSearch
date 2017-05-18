var mongoose = require('mongoose')
var Product = require('../models/cart')

var repo = {
  getCart
}
 function getCart(data , cb){
  Cart
    .findOne({ owner: req.user._id })
    .populate('items.item')
    .exec(function(err, foundCart) {
      if (err) return next(err);
      cb(err,foundCart)
    });
}