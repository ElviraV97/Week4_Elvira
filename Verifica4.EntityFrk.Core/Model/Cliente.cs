using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Verifica4.Core.Model
{
    [DataContract]
    public class Cliente
    {
        public int Id { get; set; }
        public string CodiceCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Ordine> Ordini { get; set; }
    }
}
