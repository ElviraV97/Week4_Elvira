using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verifica4.Core2.Interfaces;
using Verifica4.Core2.Model;

namespace Verifica4.EntityFrk2.Repositories
{
    public class EFClienteRepository : IRepository<Cliente>
    {
        private readonly OrdiniContext ctx;

        public EFClienteRepository() : this(new OrdiniContext()) { }

        public EFClienteRepository(OrdiniContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Add(Cliente item)
        {
            try
            {
                ctx.Clienti.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Cliente item)
        {
            try
            {
                var cliente = ctx.Clienti.Find(item.Id);

                if (cliente != null)
                    ctx.Clienti.Remove(cliente);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Cliente> Fetch()
        {
            try
            {
                return ctx.Clienti.Include(c => c.Ordini).ToList();
            }
            catch (Exception ex)
            {
                return new List<Cliente>();
            }
        }

        public Cliente GetById(int id)
        {
            try
            {
                var cliente = ctx.Clienti.Include(c => c.Ordini).FirstOrDefault(c => c.Id == id);

                return cliente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Cliente item)
        {
            try
            {
                ctx.Clienti.Update(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
