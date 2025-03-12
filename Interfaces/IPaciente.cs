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
    public interface IPaciente
    {       
            [OperationContract] // Indica que o método faz parte do contrato de serviço
            void Cadastrar(Paciente obj); // Método para cadastrar um novo dentista

            [OperationContract] // Indica que o método faz parte do contrato de serviço
            Paciente Buscar(int id); // Método para buscar um dentista pelo ID

            [OperationContract] // Indica que o método faz parte do contrato de serviço
            List<Paciente> Listar(); // Método para listar todos os dentistas

            [OperationContract] // Indica que o método faz parte do contrato de serviço
            void Deletar(int id); // Método para deletar um dentista pelo ID

            [OperationContract] // Indica que o método faz parte do contrato de serviço
            void Atualizar(Paciente objNovo); // Método para atualizar os dados de um dentista
    }
}
