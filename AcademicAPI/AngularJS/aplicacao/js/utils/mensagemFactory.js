app.factory('Mensagem', function() {

	var Mensagem = function($scope) {

		this.severidade;
		this.texto;

		$scope.mensagemAlerta = this;
		
		this.enviar = function(severidade, texto) {
			
			this.severidade = severidade;
			this.texto = texto;
			
			$scope.mensagemAlerta = this;
		};
	}

	return Mensagem;
});