using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasenlazadas
{
    internal class Nodo // se crea el objeto nodo
    {
        private int dato;  // el dato del nodo
        private Nodo siguiente;  // el dato de adelante
        private Nodo anterior;  // el dato de atras
        public int Dato
        {
            get { return dato; }  // setear el dato
            set { dato = value; }  // devolver el dato
        }
        public Nodo Siguiente
        {
            get { return siguiente; }  // setear siguiente
            set { siguiente = value; }  // devolver siguiente
        }

        public Nodo Anterior
        {
            set { anterior = value; }  // setear anterior
            get {return anterior; }  // devolver anterior

        }
    }
}
