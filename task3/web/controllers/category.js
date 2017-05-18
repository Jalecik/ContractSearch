var service = require('../../lib/category/service')

var categoryController = {
    addCategory
}

function addCategory(req, res, next) {
    var input = req.body.name;
    service.addCategory(input, (error, result) => {
        if (error) {
            return res.status(500).json(error)
        }
        return res.render('home')
    })
}

module.exports = categoryController