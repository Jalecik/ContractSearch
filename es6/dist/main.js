// var co = require('co');
// co(function*() {
"use strict";

function makeUppercase(word) {
    return word.toUpperCase();
}
var template = '<h1>' + makeUppercase('jale you are great person') + ', ' + name + '</h1>\n<p>hghghfghgfhg</p>';

document.getElementById('template').innerHTML = template;