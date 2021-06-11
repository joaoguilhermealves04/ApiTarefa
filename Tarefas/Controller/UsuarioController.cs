using apiDomin.Entities;
using ApiRepository.Contracts;
using ApiTarefas.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefas.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        [HttpPost]
        public IActionResult Post(UsuarioModel model)
        {
            try
            {
                var usuario = new Usuario();
                usuario.Nome = model.Nome;
                usuario.Email = model.Email;
                usuario.Senhar = model.Senhar;

                var emailExiste = _usuarioRepository.ObterPorEmail(model.Email);
                if (emailExiste != null)
                {
                    return StatusCode(404, "E-mail já existente");
                }

                _usuarioRepository.Inserir(usuario);

                return Ok(usuario);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(Login usuario)
        {
            try
            {
                var usuarioExistente = _usuarioRepository.Login(usuario.Email, usuario.Senha);
                if (usuarioExistente != null)
                {
                    return Ok(usuarioExistente);
                }

                return StatusCode(404, "Usuário e / ou senha inválidos");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

