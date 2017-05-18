var books = require('./list.js')
const workersController = {
    addWorkers,
    RemoveWorker,
    GetCount,
    printWorkers
}

function  AddWorkers(id, name, surname) {
listOfWorkers.push({id:this.id, name:name, surname:surname})
console.log("tests");
}

function GetCount(){
var count = listOfWorkers.count();
return count;
}

function RemoveWorker(){
parseInt(req.params.id)
var index= listOfWorkers.findIndex(num => num === id)
listOfWorkers.splice(index,1)
}

function   printWorkers(){
for (var workers in workerList){
item=workerList[workers]
}
return item;
}
module.exports = workersController

AddWorkers(4,"ff","ff");