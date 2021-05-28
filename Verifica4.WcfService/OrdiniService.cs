using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Verifica4.Core2.BusinessLayer;
using Verifica4.Core2.Interfaces;
using Verifica4.Core2.Model;
using Verifica4.EntityFrk2.Repositories;

namespace Verifica4.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OrdiniService : IOrdiniService
    {
        IOrdiniBL bl;

        public OrdiniService()
        {
            var clienteRepo = new EFClienteRepository();
            var ordineRepo = new EFOrdineRepository();
            bl = new OrdiniBL(clienteRepo, ordineRepo);
        }

        public bool AddNewCliente(Cliente cliente)
        {
            try
            {
                return bl.CreateCliente(cliente);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCliente(int id)
        {
            try
            {
                var cliente = GetClienteById(id);

                return bl.DeleteCliente(cliente);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditCliente(Cliente cliente)
        {
            try
            {
                return bl.EditCliente(cliente);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Cliente GetClienteById(int id)
        {
            try
            {
                return bl.FetchClienteById(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Cliente> GetClienti()
        {
            try
            {
                return bl.FetchClienti().ToList();
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }
    }
}
