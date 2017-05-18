var service = require('../../lib/cart/service')

var cartController = {
    getCart
}

function getCart(req, res, next) {
    var productId = req.user._id 
    service.getCart(productId,(error, result)=>{
           if (error) {
            return res.status(500).json(error)
        }
        return res.render('product-main', {
        products: result
        })
    });
    
}

module.exports = cartController