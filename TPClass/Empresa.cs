using System;
using System.Collections.Generic;
using System.Text;

namespace TPClass
{
    class Empresa
    {
        public string nombre;
        public string direccion;
        public string telefono;
        public string mail;

        // Constructor
        public Empresa(string nombre, string direccion, string telefono, string mail)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.mail = mail;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
    }
}
