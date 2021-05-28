using System;
using System.Collections.Generic;
using Verifica4.Core2.Model;

namespace Verifica4.Core2.Interfaces
{
    public interface IOrdiniBL
    {
        IEnumerable<Cliente> FetchClienti(Func<Cliente, bool> filter = null);
        Cliente FetchClienteById(int id);
        bool CreateCliente(Cliente newCliente);
        bool EditCliente(Cliente editedCliente);
        bool DeleteCliente(Cliente clienteToBeDeleted);

        IEnumerable<Ordine> FetchOrdini(Func<Ordine, bool> filter = null);
        Ordine FetchOrdineById(int id);
        bool CreateOrdine(Ordine newOrdine);
        bool EditOrdine(Ordine editedOrdine);
        bool DeleteOrdine(Ordine ordineToBeDeleted);
    }
}