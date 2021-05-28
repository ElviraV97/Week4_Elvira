
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verifica4.Core.Interfaces;
using Verifica4.Core.Model;

namespace Verifica4.Core.BusinessLayer
{
    public class OrdiniBL : IOrdiniBL
    {
        private readonly IRepository<Cliente> clienteRepo;
        private readonly IRepository<Ordine> ordineRepo;

        public OrdiniBL(
            IRepository<Cliente> clienteRepo,
            IRepository<Ordine> ordineRepo
            )
        {
            this.clienteRepo = clienteRepo;
            this.ordineRepo = ordineRepo;
        }

        public bool CreateCliente(Cliente newCliente)
        {
            return clienteRepo.Add(newCliente);
        }

        public bool CreateOrdine(Ordine newOrdine)
        {
            return ordineRepo.Add(newOrdine);
        }

        public bool DeleteCliente(Cliente clienteToBeDeleted)
        {
            return clienteRepo.Delete(clienteToBeDeleted);
        }

        public bool DeleteOrdine(Ordine ordineToBeDeleted)
        {
            return ordineRepo.Delete(ordineToBeDeleted);
        }

        public bool EditCliente(Cliente editedCliente)
        {
            return clienteRepo.Update(editedCliente);
        }

        public bool EditOrdine(Ordine editedOrdine)
        {
            return ordineRepo.Update(editedOrdine);
        }

        public IEnumerable<Cliente> FetchClienti(Func<Cliente, bool> filter = null)
        {
            return clienteRepo.Fetch();
        }

        public IEnumerable<Ordine> FetchOrdini(Func<Ordine, bool> filter = null)
        {
            return ordineRepo.Fetch();
        }
    }
}
