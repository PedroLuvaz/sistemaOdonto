using System;
using Entidades;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace Interfaces
{
    [ServiceContract] // Indica que a interface define um contrato de serviço WCF
    public interface IDentista
    {
        [OperationContract] // Indica que o método faz parte do contrato de serviço
        void Cadastrar(Dentista obj); // Método para cadastrar um novo dentista

        [OperationContract] // Indica que o método faz parte do contrato de serviço
        Dentista Buscar(int id); // Método para buscar um dentista pelo ID

        [OperationContract] // Indica que o método faz parte do contrato de serviço
        List<Dentista> Listar(); // Método para listar todos os dentistas

        [OperationContract] // Indica que o método faz parte do contrato de serviço
        void Deletar(int id); // Método para deletar um dentista pelo ID

        [OperationContract] // Indica que o método faz parte do contrato de serviço
        void Atualizar(Dentista objNovo); // Método para atualizar os dados de um dentista
    }

}
