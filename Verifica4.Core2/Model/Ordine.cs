using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica4.Core2.Model
{
    public class Ordine
    {
        public int Id { get; set; }
        public DateTime DataOrdine { get; set; }
        public string CodiceOrdine { get; set; }
        public string CodiceProdotto { get; set; }
        public decimal Importo { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
