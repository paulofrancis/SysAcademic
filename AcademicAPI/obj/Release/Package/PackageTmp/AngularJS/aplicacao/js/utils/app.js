var app = angular.module('AngularJS', ['ui.bootstrap', 'ngResource', 'ngRoute'])

.constant("URLWS", {
    "CONSULTAR_NOTAS": "/AngularJS/resources/nota/consultar",
    "CONSULTAR_DISCIPLINAS": "/AngularJS/resources/disciplina/consultar"
})

.constant("MSG", {
    "I": "info",
    "W": "warning",
    "D": "danger",
    "S": "success"
})

.config(function($locationProvider){
    $locationProvider.html5Mode({
        enabled : true,
        requireBase : false
    }).hashPrefix('#');
});