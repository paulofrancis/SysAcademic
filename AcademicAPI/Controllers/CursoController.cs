using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AcademicAPI.Controllers
{
  public class CursoController : ApiController
  {    
    // GET api/curso
    public IEnumerable<Models.curso> Get()
    {
      using (var cxt = new Models.academicContext())
      {
        var result = cxt.cursos.OrderBy(s => s.nome);

        return result.ToList();
      }
    }

    // GET api/curso/5
    public Models.curso Get(string id)
    {
      using (var cxt = new Models.academicContext())
      {
        var qry = cxt.cursos.Where(s => s.sigla == id);
      }


      return new Models.curso();
    }    
  }
}
