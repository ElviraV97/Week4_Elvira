using System;
using System.Collections.Generic;
using Verifica4.Core.Model;

namespace Verifica4.Core.Interfaces
{
    public interface IOrdiniBL
    {
        IEnumerable<Cliente> FetchClienti(Func<Cliente, bool> filter = null);
        bool CreateCliente(Cliente newCliente);
        bool EditCliente(Cliente editedCliente);
        bool DeleteCliente(Cliente clienteToBeDeleted);

        IEnumerable<Ordine> FetchOrdini(Func<Ordine, bool> filter = null);
        bool CreateOrdine(Ordine newOrdine);
        bool EditOrdine(Ordine editedOrdine);
        bool DeleteOrdine(Ordine ordineToBeDeleted);
    }
}