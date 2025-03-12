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
        // Método para cadastrar um novo paciente no banco de dados
        public void Cadastrar(Paciente obj)
        {
            using (var ctx = new SistemContext())
            {
                ctx.Pacientes.Add(obj); // Adiciona o objeto paciente ao contexto
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }

        // Método para buscar um paciente pelo ID
        public Paciente Buscar(int id)
        {
            Paciente obj = new Paciente();
            using (var ctx = new SistemContext())
            {
                obj = ctx.Pacientes.Find(id); // Encontra o paciente pelo ID
            }

            return obj; // Retorna o objeto paciente encontrado
        }

        // Método para listar todos os pacientes ordenados pelo nome
        public List<Paciente> Listar()
        {
            using (var ctx = new SistemContext())
            {
                var Pacientes = (from obj in ctx.Pacientes select obj).OrderBy(x => x.Nome).ToList(); // Seleciona e ordena os pacientes pelo nome
                return Pacientes; // Retorna a lista de pacientes
            }
        }

        // Método para atualizar os dados de um paciente existente
        public void Atualizar(Paciente objNew)
        {
            using (var ctx = new SistemContext())
            {
                Paciente objOld = ctx.Pacientes.Find(objNew.Id); // Encontra o paciente pelo ID
                objOld.Nome = objNew.Nome; // Atualiza o nome
                objOld.Telefone = objNew.Telefone; // Atualiza o telefone
                objOld.Celular = objNew.Celular; // Atualiza o celular
                objOld.CEP = objNew.CEP; // Atualiza o CEP
                objOld.Email = objNew.Email; // Atualiza o email
                objOld.Endereco = objNew.Endereco;
                objOld.Complemento = objNew.Complemento;
                objOld.Nascimento = objNew.Nascimento;
                objOld.Sexo = objNew.Sexo;
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }

        // Método para deletar um paciente pelo ID
        public void Deletar(int id)
        {
            using (var ctx = new SistemContext())
            {
                Paciente obj = ctx.Pacientes.Find(id); // Encontra o paciente pelo ID
                ctx.Pacientes.Remove(obj); // Remove o paciente do contexto
                ctx.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }
    }
}
