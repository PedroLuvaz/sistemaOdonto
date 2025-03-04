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
    [ServiceContract]
    public interface IDentista
    {
        [OperationContract]
        void Cadastrar(Dentista obj);

        [OperationContract]
        Dentista Buscar(int id);

        [OperationContract]
        List<Dentista> Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Atualizar(Dentista objNovo);
    }

}
