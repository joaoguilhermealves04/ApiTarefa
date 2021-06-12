using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Entities
{
    public class Usuario : EntityBase
    {
        #region Propriedades 
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        #endregion
    }
}
