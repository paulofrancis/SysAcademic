using System;
using System.Collections.Generic;

namespace AcademicAPI.Models
{
    public partial class nota
    {
        public int id { get; set; }
        public string disciplina { get; set; }
        public decimal valor { get; set; }
        public System.DateTime data { get; set; }
    }
}
