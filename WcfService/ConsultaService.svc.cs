using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ConsultaService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ConsultaService.svc ou ConsultaService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ConsultaService : IConsulta
    {
        // Instância do repositório de dentistas
        private ConsultaRep rep = new ConsultaRep();

        // Método para cadastrar um novo dentista
        public void Cadastrar(Consulta obj)
        {
            rep.Cadastrar(obj);
        }

        // Método para buscar um dentista pelo ID
        public Consulta Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public IQueryable<Consulta> Buscar(Dentista dentista)
        {
            return rep.Buscar(dentista);
        }

        public List<Consulta> Buscar(Dentista dentista, DateTime data)
        {
            return rep.Buscar(dentista, data);
        }


        // Método para deletar um dentista pelo ID
        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        // Método para atualizar os dados de um dentista
        public void Atualizar(Consulta objNovo)
        {
            rep.Atualizar(objNovo);
        }
    }
}
