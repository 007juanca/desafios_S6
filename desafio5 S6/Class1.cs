using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio5_S6
{
    public class Caja
    {
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public double CalcularVolumen()
        {
            return Alto * Ancho * Largo;
        }
    }
}