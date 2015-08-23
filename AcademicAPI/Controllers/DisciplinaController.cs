using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AcademicAPI.Controllers
{
  public class DisciplinaController : ApiController
  {
    // GET api/disciplina
    public IEnumerable<Models.disciplina> Get()
    {
      using (var cxt = new Models.academicContext())
      {
        var result = cxt.disciplinas.OrderBy(s => s.nome);

        return result.ToList();
      }
    }

    public static Models.disciplina GetDisciplina(string sigla)
    {
      using (var cxt = new Models.academicContext())
      {
        var qry = cxt.disciplinas.Find(sigla);

        return qry;
      }
    }
  }
}
