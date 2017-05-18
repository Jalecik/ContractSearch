var controller = require('../controllers/product')

var productrouter = function (expres) {
    var Router = expres.Router()

    Router.route('/').get(controller.getProduct)

    return Router
}

module.exports = productrouter