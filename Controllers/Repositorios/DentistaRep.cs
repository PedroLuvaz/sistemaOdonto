using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class DentistaRep
    {
        // Método para cadastrar um novo dentista no banco de dados
        public void Cadastrar(Dentista obj)
        {
            using (var ctx = new SistemContext())
            {
                ctx.Dentistas.Add(obj); // Adiciona o objeto dentista ao contexto
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }

        // Método para buscar um dentista pelo ID
        public Dentista Buscar(int id)
        {
            Dentista obj = new Dentista();
            using (var ctx = new SistemContext())
            {
                obj = ctx.Dentistas.Find(id); // Encontra o dentista pelo ID
            }

            return obj; // Retorna o objeto dentista encontrado
        }

        // Método para listar todos os dentistas ordenados pelo nome
        public List<Dentista> Listar()
        {
            using (var ctx = new SistemContext())
            {
                var Dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Nome).ToList(); // Seleciona e ordena os dentistas pelo nome
                return Dentistas; // Retorna a lista de dentistas
            }
        }

        // Método para atualizar os dados de um dentista existente
        public void Atualizar(Dentista objNew)
        {
            using (var ctx = new SistemContext())
            {
                Dentista objOld = ctx.Dentistas.Find(objNew.Id); // Encontra o dentista pelo ID
                objOld.Nome = objNew.Nome; // Atualiza o nome
                objOld.Telefone = objNew.Telefone; // Atualiza o telefone
                objOld.Celular = objNew.Celular; // Atualiza o celular
                objOld.CRO = objNew.CRO; // Atualiza o CRO
                objOld.Email = objNew.Email; // Atualiza o email
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }

        // Método para deletar um dentista pelo ID
        public void Deletar(int id)
        {
            using (var ctx = new SistemContext())
            {
                Dentista obj = ctx.Dentistas.Find(id); // Encontra o dentista pelo ID
                ctx.Dentistas.Remove(obj); // Remove o dentista do contexto
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }
    }
}
