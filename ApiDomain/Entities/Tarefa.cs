using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class Tarefa : EntityBase
    {
          public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
