var controller = require('../controllers/cart')

var cartrouter = function (expres) {
    var Router = expres.Router()

    Router.route('/').get(controller.getCart)

    return Router
}

module.exports = cartrouter