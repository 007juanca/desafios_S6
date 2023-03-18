using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio4_S6
{
    public class Rectangulo
    {
        private double _alto;
        private double _largo;

        public Rectangulo(double alto, double largo)
        {
            _alto = alto;
            _largo = largo;
        }

        public double Alto
        {
            get { return _alto; }
            set { _alto = value; }
        }

        public double Largo
        {
            get { return _largo; }
            set { _largo = value; }
        }

        public double SuperficieFrontal
        {
            get { return _alto * _largo; }
        }
    }
}
