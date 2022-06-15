using System;
using TesteBack.Enum;

namespace TesteBack.Model
{
    public class MoedaModel
    {
        public int MoedaId { get; set; }
        public MoedaEnum Cotacao { get; set; }
        public string Moeda { get; set; }
        public DateTime Data { get; set; }
    }
}
