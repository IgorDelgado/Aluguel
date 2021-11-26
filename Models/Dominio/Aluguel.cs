using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCaçamba.Models.Dominio
{
    public class Aluguel
    {

        public int ID { get; set; }
        public int DdCliente { get; set; }
        public int DdCacamba { get; set; }
        public DateTime Data_aluguel { get; set; }
        public DateTime Data_devolucao { get; set; }
        public float Valor { get; set; }
    }
}
