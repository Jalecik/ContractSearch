var Category = require('../models/category')

var repo = {
    addCategory
}

function addCategory(data, cb){
    var category = new Category()
    category.name = data
    category.save(cb)
}

module.exports = repo