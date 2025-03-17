using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
        [ServiceContract] // Indica que a interface define um contrato de serviço WCF
    public interface IConsulta
    {

        [OperationContract]
        void Cadastrar(Consulta obj);

        [OperationContract(Name = "BuscarPorId")]
        Consulta Buscar(int id);

        [OperationContract(Name = "BuscarPorDentista")]
        IQueryable<Consulta> Buscar(Dentista dentista);

        [OperationContract(Name = "BuscarPorDentistaData")]
        List<Consulta> Buscar(Dentista dentista, DateTime data);

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Atualizar(Consulta objNovo);

    }
}
