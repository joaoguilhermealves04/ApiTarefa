using apiDomin.Entities;
using ApiRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRepository.Repository
{
    class UsuarioRepository : IUsuarioRepository
    {
        public void Inserir(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
