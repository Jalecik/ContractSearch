var controller = require('../controllers/category')

var categoryrouter = function (expres) {
    var Router = expres.Router()

    Router.route('/').get(controller.addCategory)

    return Router
}

module.exports = categoryrouter