using System;
using System.Collections.Generic;
using System.Text;

namespace apiDomain.Entities
{
    public class Tarefa : EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
