using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();
        Habilidade BuscarPorId(int id);
        void Cadastrar(Habilidade novaHabilidade);
        void Deletar(int id);
        void Atualizar(int id, Habilidade habilidadeAtualizada);
        List<Habilidade> ListarComTipo();
    }
}
