app.service('NotaService', function($resource) {
	return $resource("/api/nota/", {matricula: '',	siglaCurso: '', siglaDisciplina: '', dataInicial: '', dataFinal: ''});
});