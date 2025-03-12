using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Controllers;
using Controllers.Repositorios;

namespace WcfService
{
	// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "PacienteService" no arquivo de código, svc e configuração ao mesmo tempo.
	// OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione PacienteService.svc ou PacienteService.svc.cs no Gerenciador de Soluções e inicie a depuração.
	public class PacienteService : IPaciente
	{
        // Instância do repositório de dentistas
        private PacienteRep rep = new PacienteRep();

        // Método para cadastrar um novo dentista
        public void Cadastrar(Paciente obj)
        {
            rep.Cadastrar(obj);
        }

        // Método para buscar um dentista pelo ID
        public Paciente Buscar(int id)
        {
            return rep.Buscar(id);
        }

        // Método para listar todos os dentistas
        public List<Paciente> Listar()
        {
            return rep.Listar();
        }

        // Método para deletar um dentista pelo ID
        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        // Método para atualizar os dados de um dentista
        public void Atualizar(Paciente objNovo)
        {
            rep.Atualizar(objNovo);
        }
    }
}
