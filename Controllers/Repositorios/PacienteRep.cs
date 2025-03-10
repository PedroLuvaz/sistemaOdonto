using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class PacienteRep
    {
        // Método para cadastrar um novo dentista no banco de dados
        public void Cadastrar(Paciente obj)
        {
            using (var ctx = new SistemContext())
            {
                ctx.Pacientes.Add(obj); // Adiciona o objeto dentista ao contexto
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }

        // Método para buscar um dentista pelo ID
        public Paciente Buscar(int id)
        {
            Paciente obj = new Paciente();
            using (var ctx = new SistemContext())
            {
                obj = ctx.Pacientes.Find(id); // Encontra o dentista pelo ID
            }

            return obj; // Retorna o objeto dentista encontrado
        }

        // Método para listar todos os dentistas ordenados pelo nome
        public List<Paciente> Listar()
        {
            using (var ctx = new SistemContext())
            {
                var Pacientes = (from obj in ctx.Pacientes select obj).OrderBy(x => x.Nome).ToList(); // Seleciona e ordena os dentistas pelo nome
                return Pacientes; // Retorna a lista de dentistas
            }
        }

        // Método para atualizar os dados de um dentista existente
        public void Atualizar(Paciente objNew)
        {
            using (var ctx = new SistemContext())
            {
                Paciente objOld = ctx.Pacientes.Find(objNew.Id); // Encontra o dentista pelo ID
                objOld.Nome = objNew.Nome; // Atualiza o nome
                objOld.Telefone = objNew.Telefone; // Atualiza o telefone
                objOld.Celular = objNew.Celular; // Atualiza o celular
                objOld.CEP = objNew.CEP; // Atualiza o CRO
                objOld.Email = objNew.Email; // Atualiza o email
                objOld.Endereco = objNew.Endereco;
                objOld.Complemento = objNew.Complemento;
                objOld.Nascimento = objNew.Nascimento;
                objOld.Sexo = objNew.Sexo;
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }

        // Método para deletar um dentista pelo ID
        public void Deletar(int id)
        {
            using (var ctx = new SistemContext())
            {
                Paciente obj = ctx.Pacientes.Find(id); // Encontra o dentista pelo ID
                ctx.Pacientes.Remove(obj); // Remove o dentista do contexto
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }
    }
}
