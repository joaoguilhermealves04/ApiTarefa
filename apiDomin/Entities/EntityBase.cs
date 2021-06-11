using System;
using System.Collections.Generic;
using System.Text;

namespace apiDomain.Entities
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        #region Construtor
        public EntityBase()
        {
            Id = Guid.NewGuid();

            DataCadastro = DateTime.Now;
            DataAlteracao = DateTime.Now;
        }
        #endregion
    }
}
