using apiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace apiDomin.Entities
{
    public class Usuario : EntityBase
    {
        #region Propriedades 
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senhar { get; set; }

        #endregion
    }
}
