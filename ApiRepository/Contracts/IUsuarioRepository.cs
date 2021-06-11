﻿using apiDomin.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace ApiRepository.Contracts
{
    public interface IUsuarioRepository
    {
        void Inserir(Usuario usuario);

        Usuario ObterPorEmail(string email);


        Usuario Login(string email, string senha);
       
    }
}
