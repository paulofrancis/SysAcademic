using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace AcademicAPI.Controllers
{
  public class NotaController : ApiController
  {
    public struct NotaRetorno
    {
      public Models.disciplina disciplina { get; set; }
      public DateTime dataPostagem { get; set; }
      public double valor { get; set; }
    }

    // POST api/nota/5
    public Models.nota Post(FormDataCollection data)
    {
      using (var cxt = new Models.academicContext())
      {
        string sql = @"SELECT  * 
                        FROM   nota         
                        WHERE  disciplina = @disciplina 
                                AND data BETWEEN @datainicio AND @datafim";

        var notas = cxt.Database.SqlQuery<Models.nota>(sql, new SqlParameter("@disciplina", data["disciplina"].ToString()),
                                                            new SqlParameter("@dataInicio", data["dataInicio"].ToString()),
                                                            new SqlParameter("@dataFim",    data["dataFim"].ToString())).ToList();

        var retorno = new Models.nota();
        foreach (var item in notas)
        {
          //retorno.disciplina = Controllers.DisciplinaController.GetDisciplina(item.disciplina);
          retorno.valor = item.valor;
          retorno.data = item.data;
        }

        return retorno;
      }
    }

    public ICollection<NotaRetorno> GetByParams(string dataFinal, string dataInicial, string matricula, string siglaCurso, string siglaDisciplina, string tipoUsuario)
    {
      using (var cxt = new Models.academicContext())
      {
        string sql = @"SELECT  * 
                        FROM   nota         
                        WHERE  disciplina = @disciplina 
                                AND data BETWEEN @datainicio AND @datafim";

        var notas = cxt.Database.SqlQuery<Models.nota>(sql, new SqlParameter("@disciplina", siglaDisciplina),
                                                            new SqlParameter("@dataInicio", dataInicial),
                                                            new SqlParameter("@dataFim", dataFinal)).ToList();

        var retorno = new List<NotaRetorno>();
        foreach (var item in notas)
        {
          retorno.Add(
            new NotaRetorno()
            {
              disciplina = Controllers.DisciplinaController.GetDisciplina(item.disciplina),
              dataPostagem = item.data,
              valor = Convert.ToDouble(item.valor)
            }
          );
        }

        return retorno;
      }
    }
    
  }
}
