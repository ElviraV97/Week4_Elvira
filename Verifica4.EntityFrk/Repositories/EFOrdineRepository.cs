using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verifica4.Core2.Interfaces;
using Verifica4.Core2.Model;

namespace Verifica4.EntityFrk.Repositories
{
    public class EFOrdineRepository : IRepository<Ordine>
    {

        private readonly OrdiniContext ctx;

        public EFOrdineRepository() : this(new OrdiniContext()) { }

        public EFOrdineRepository(OrdiniContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Add(Ordine item)
        {
            try
            {
                ctx.Ordini.Add(item);
                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Ordine item)
        {
            try
            {
                var ordine = ctx.Ordini.Find(item.Id);

                if (ordine != null)
                    ctx.Ordini.Remove(ordine);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Ordine> Fetch()
        {
            try
            {
                return ctx.Ordini.Include(c => c.Cliente).ToList();
            }
            catch (Exception ex)
            {
                return new List<Ordine>();
            }
        }

        public Ordine GetById(int id)
        {
            try
            {
                var ordine = ctx.Ordini.Include(c => c.Cliente).FirstOrDefault(o => o.Id == id);

                return ordine;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update(Ordine item)
        {
            try
            {
                ctx.Ordini.Update(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
