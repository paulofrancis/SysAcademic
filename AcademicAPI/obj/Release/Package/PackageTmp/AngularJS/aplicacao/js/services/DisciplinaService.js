app.service('DisciplinaService', function($resource) {
	return $resource("/api/disciplina/", {curso:'', matricula:''});

});