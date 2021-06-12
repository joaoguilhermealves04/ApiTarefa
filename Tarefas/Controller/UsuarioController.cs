using ApiDomain.Entities;
using ApiRepository.Contracts;
using ApiTarefas.Model;
using Microsoft.AspNetCore.Mvc;
using System;

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


        [HttpPost("Cadastrar")]
        public IActionResult Post(UsuarioModel model)
        {
            try
            {
                var usuario = new Usuario();
                usuario.Nome = model.Nome;
                usuario.Email = model.Email;
                usuario.Senha = model.Senhar;

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
                var usuarioExistente = _usuarioRepository.ObterPorEmail(usuario.Email);
                if (usuarioExistente != null)
                {
                    return  StatusCode(400,"Não existe Usuario Com esse Email.");
                }
                if(usuarioExistente.Senha != usuario.Senha)
                {
                    return StatusCode(400, "Senha invalida ");
                }

                return StatusCode(200, "Usuário e / ou senha inválidos");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

