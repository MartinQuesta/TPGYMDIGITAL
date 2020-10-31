using System;
using System.Collections.Generic;
using System.Text;

namespace TPClass
{
    class Objetivo
    {
        public string nombre;
        public double esfuerzoTotal;
        public List<Double> estadisticaTotal;

        public Objetivo(string nombre, double esfuerzoTotal)
        {
            this.nombre = nombre;
            this.esfuerzoTotal = esfuerzoTotal;
            this.estadisticaClases = new List<Clase>();
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double EsfuerzoTotal
        {
            get { return esfuerzoTotal; }
            set { esfuerzoTotal = value; }
        }

       
    }
}
