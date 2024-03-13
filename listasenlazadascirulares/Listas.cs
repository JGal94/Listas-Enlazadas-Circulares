using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasenlazadas
{
    internal class Listas
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Listas()
        {
            Primero = null;
            Ultimo = null;
        }
        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato para el nuevo nodo: ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = Primero;
            }
            else if(Primero.Siguiente == null)
            {
                nuevo.Anterior = Ultimo;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
                Primero.Siguiente = Ultimo;

            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Anterior = Ultimo;
                Ultimo = nuevo;
            }
            Console.WriteLine("\n\nSe incerto: " + Ultimo.Dato + "\n\n");

        }

        public void desplegarLista()
        {
            Nodo actual = new Nodo();
            actual = Primero;
            if (Primero != null)
            {
                while(actual != null)
                {
                    Console.WriteLine("{0}", actual.Dato);
                    actual = actual.Siguiente;
                }
                
            }
        }

        public void eliminarNodo()
        {
            Nodo actual = new Nodo();
            actual = Primero;
            Nodo anterior = new Nodo();
            anterior = null;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el dato del nodo a buscar para eliminar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if ( Primero != null)
            {
                while(actual != null && Encontrado != true)
                {
                    if(actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("El nodo con el dato {0} Encontrado", nodoBuscado);
                        if(actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }else if (actual == Ultimo)
                        {
                            anterior.Siguiente = null;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;

                        }
                        Console.WriteLine("Nodo Eliminado");
                        Encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("Nodo no encontrado");
                }
            }
            {
                
            }
        }

       



    }
}
