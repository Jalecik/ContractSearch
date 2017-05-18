var express = require('express'),
    bodyParser = require('body-parser')

var app = express(),
    port = process.env.PORT || 3000

var userCtrl = require('./controllers/user')

app.use(bodyParser.json())

app.listen(port, (err) => {
    if (err) {
        console.log('Error ocured:', err)
    }

    console.log(`Server listening on port: ${port}`)
})


app.get('/users', userCtrl.getAll)

app.get('/users/:id', userCtrl.getById)

app.post('/users', userCtrl.addUser)

