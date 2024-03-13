using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasenlazadas
{
    internal class Nodo
    {
        private int dato;
        private Nodo siguiente;
        private Nodo anterior;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo Anterior
        {
            set { anterior = value; }
            get {return anterior; }

        }
    }
}
