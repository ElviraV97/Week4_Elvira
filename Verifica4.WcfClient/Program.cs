using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verifica4.Core2.BusinessLayer;
using Verifica4.Core2.Interfaces;
using Verifica4.EntityFrk2.Repositories;
using Verifica4.WcfClient.OrdiniServiceReference;

namespace Verifica4.WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {

            OrdiniServiceClient service = new OrdiniServiceClient();
                                    
            Cliente cliente;

            Console.Write("ID: ");
            string id = Console.ReadLine();
            int.TryParse(id, out int clientId);

            cliente = service.GetClienteById(clientId);

            Console.WriteLine($"{cliente.Id} - {cliente.Nome} {cliente.Cognome}");

            Console.WriteLine("Press a button to exit: ");
            Console.ReadLine();
        }
    }
}
