var users = require('../data/users.json')

const userController = {
    getAll,
    getById,
    addUser
}

function getAll(req, res, next) {
    res.status(200).json(users)
}

function getById(req, res, next) {
    var id = parseInt(req.params.id)
    var index = users.findIndex(function (user) {
        return user.id === id
    })

    if (index !== -1) {
        res.json(users[index])
    } else {
        res.status(404).send('Not found')
    }
}

function addUser(req, res, next) {
    var user = req.body
    user.id = users.length + 1
    users.push(user)
    res.send(users)
}

module.exports = userController