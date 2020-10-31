using System;
using System.Collections.Generic;
using System.Text;

namespace TPClass
{
    class Clase
    {
        
        private string nombre;
        private int esfuerzo;
        private string url;

        public Clase(string nombre, int esfuerzo, string url)
        {
            this.nombre = nombre;
            this.esfuerzo = esfuerzo;
            this.url = url;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Esfuerzo
        {
            get { return esfuerzo; }
            set { esfuerzo = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
