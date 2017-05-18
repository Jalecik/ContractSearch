// var co = require('co');
// co(function*() {
// "use strict"
// function makeUppercase(word){
//     return word.toUpperCase();
// }
// let template =`<h1>${makeUppercase('jale')}, ${name}</h1>
// <p>hghghfghgfhg</p>` ;

// document.getElementById('template').innerHTML=template;
// function getData(method, url){
//     return new Promise(function(resolve, reject){
//     var xhr = new XMLHttpRequest();
//     xhr.open(method, url);
//     xhr.onload=function(){
//         if(this.status >= 200 && this.status <300){
//         resolve(xhr.response);
//     } else {
// reject({
//     status:this.status,
//     statusText: xhr.statusText
// });
//     }
//     };
//     xhr.send();
// });
// }
// getData('GET','https://jsonplaceholder.typicode.com/todos').then(function(data){
//     console.log(data);
// }).catch(function(err){
//     console.log(err);
// })
   

   function *g1(){
       console.log('hello');
       yield 'yield1 ran..';
           console.log('hello2');
       yield 'yield2 ran..';
       return 'returned..';
   }

   var g= g1();
   console.log(g.next().value);
    console.log(g.next());
    console.log(g.next());