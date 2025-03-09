using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Interfaces;
using Entidades;
using Controllers;
using Controllers.Repositorios;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class DentistaService : IDentista
    {
        // Instância do repositório de dentistas
        private DentistaRep rep = new DentistaRep();

        // Método para cadastrar um novo dentista
        public void Cadastrar(Dentista obj)
        {
            rep.Cadastrar(obj);
        }

        // Método para buscar um dentista pelo ID
        public Dentista Buscar(int id)
        {
            return rep.Buscar(id);
        }

        // Método para listar todos os dentistas
        public List<Dentista> Listar()
        {
            return rep.Listar();
        }

        // Método para deletar um dentista pelo ID
        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        // Método para atualizar os dados de um dentista
        public void Atualizar(Dentista objNovo)
        {
            rep.Atualizar(objNovo);
        }
    }
}
