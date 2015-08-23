app.controller('loginController', function($scope, $window){
	
	$scope.tipoUsuario ="";
	$scope.login ="";
	$scope.password ="";
	
	$scope.acessar = function () {
		$window.location.href = '/AngularJS/aplicacao/paginas/area-restrita.html?tipoUsuario='+$scope.tipoUsuario+'&login='+$scope.login+'&password='+$scope.password;
    };
	
});