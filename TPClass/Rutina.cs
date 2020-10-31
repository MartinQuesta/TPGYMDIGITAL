using System;
using System.Collections.Generic;
using System.Text;

namespace TPClass
{
    class Rutina
    {
        public string nombre;
        public int esfuerzo;
        public string[] ejercicios;
        public int[] tablaDeRepeticion;

        public Rutina(string nombre, int esfuerzo)
        {
            this.nombre = nombre;
            this.esfuerzo = esfuerzo;
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
    }
}
