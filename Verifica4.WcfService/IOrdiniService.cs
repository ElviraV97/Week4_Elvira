using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Verifica4.Core2.Model;

namespace Verifica4.WcfService
{
    [ServiceContract]
    public interface IOrdiniService
    {
        [OperationContract]
        List<Cliente> GetClienti();

        [OperationContract]
        Cliente GetClienteById(int id);

        [OperationContract]
        bool AddNewCliente(Cliente cliente);

        [OperationContract]
        bool EditCliente(Cliente cliente);

        [OperationContract]
        bool DeleteCliente(int id);
    }
}
