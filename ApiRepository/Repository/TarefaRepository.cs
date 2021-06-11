using apiDomain.Entities;
using ApiRepository.Context;
using ApiRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRepository.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly TarefaContexto _tarefaContexto;
        public TarefaRepository(TarefaContexto tarefaContexto)
        {
            _tarefaContexto = tarefaContexto;
        }

        public void Adicinoar(Tarefa tarefa)
        {
            _tarefaContexto.Add(tarefa);
            _tarefaContexto.SaveChanges();
        }

        public void Atualizar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public Tarefa ObterPornome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Tarefa> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Tarefa ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
