using System;
using System.Collections.Generic;
using System.Text;

namespace TPClass
{
    class Oferta
    {
        public int costo;

        //Constructor
        public Oferta(int costo) 
        {
            this.costo = costo;
        }

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }
    }
}
