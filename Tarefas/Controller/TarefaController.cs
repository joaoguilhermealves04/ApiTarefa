using ApiDomain.Entities;
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
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaController(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        [HttpPost]
        public IActionResult Post(TarefasModel model)
        {
            try
            {
                var tarefa = new Tarefa()
                {
                    Nome = model.Nome,
                    Descricao = model.Descrição
                };

                _tarefaRepository.Adicinoar(tarefa);

                return Ok("Tarefa adicionada com sucesso!");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(AlterarTarefas model)
        {
            try
            {
                var tarefa = _tarefaRepository.ObterPorId(model.IdTarefa);

                tarefa.Descricao = model.Descricao;
                tarefa.Nome = model.Nome;

                _tarefaRepository.Atualizar(tarefa);

                return Ok("Tarefa atualizada com sucesso!");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var tarefa = _tarefaRepository.ObterPorId(id);
                _tarefaRepository.Excluir(tarefa);

                return Ok("Tarefa removida com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }


        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                var tarefas = _tarefaRepository.ObterTodos();
                return Ok(tarefas);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("ObterPornome")]
        public IActionResult ObterPornome(string nome)
        {
            try
            {
                var tarefa = _tarefaRepository.ObterPornome(nome);
                return Ok(tarefa);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
