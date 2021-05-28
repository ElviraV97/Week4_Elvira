using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verifica4.Core2.BusinessLayer;
using Verifica4.Core2.Interfaces;
using Verifica4.Core2.Model;
using Verifica4.EntityFrk2.Repositories;


namespace Verifica4.WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
         

            IOrdiniBL bl;

            var clienteRepo = new EFClienteRepository();
            var ordineRepo = new EFOrdineRepository();
            bl = new OrdiniBL(clienteRepo, ordineRepo);

            Cliente cliente;

            Console.Write("ID: ");
            string id = Console.ReadLine();
            int.TryParse(id, out int clientId);

            cliente = bl.FetchClienteById(clientId);

            Console.WriteLine($"{cliente.Id} - {cliente.Nome} {cliente.Cognome}");

            Console.WriteLine("Press a button to exit: ");
            Console.ReadLine();
        }
    }
}
