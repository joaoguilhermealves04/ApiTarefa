using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefas.Model
{
    public class AlterarTarefas
    {
        public Guid IdTarefa { get; set; }
        [Required(ErrorMessage = "Por favor, informe o nome .")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por favor, informe o Descrição .")]
        public string Descricao { get; set; } 
    }
}
