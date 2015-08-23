app.service('CursoService', function($resource) {
	return $resource("/api/curso/", {matricula:''});
});