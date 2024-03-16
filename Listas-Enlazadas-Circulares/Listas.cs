using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasenlazadas
{
    internal class Listas
    {
        private Nodo Primero = new Nodo();  // se crea nodo que almacena el primero
        private Nodo Ultimo = new Nodo();  // se crea nodo que almacena el ultimo

        public Listas()
        {
            Primero = null;  // al inicio se establece null
            Ultimo = null;  // al inicio se establece null
        }
        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();  // se crea el nodo nuevo 
            Console.WriteLine("Ingrese el dato para el nuevo nodo: ");
            try  // try para captar algun error por introduccion de datos distintos a valores enteros
            {
                nuevo.Dato = int.Parse(Console.ReadLine());  // se solicita el valor del nodo nuevo
                if (Primero == null)  // si el primero es null es decir la lista esta vacias
                {
                    Primero = nuevo;  // el nuevo dato se vuelve el primero
                    Ultimo = Primero;  // al mismo tiempo que se convierte en el ultimo ya que es el unico
                }
                else if (Primero.Siguiente == null)  // si la lista ya tiene un dato
                {
                    nuevo.Anterior = Ultimo;  // antes del nuevo se pone el primero
                    Ultimo.Siguiente = nuevo;  // el ultimo apunta a el nuevo
                    Ultimo = nuevo; // el ultimo se convierte el nuevo
                    Primero.Siguiente = Ultimo;  // el primero apunta a el ultimo

                    Ultimo.Siguiente = Primero;  // se señala que despues del ultimo sigue el primero
                    Primero.Anterior = Ultimo;  // se señala que antes del primero esta el ultimo

                }
                else  // si hay mas de un dato
                {
                    Ultimo.Siguiente = nuevo;  //ultimo apunta a nuevo
                    nuevo.Anterior = Ultimo;  // nuevo apunta a anterior
                    Ultimo = nuevo;  // nuevo se convierte en ultimo

                    Ultimo.Siguiente = Primero;   // se señala que despues del ultimo sigue el primero
                    Primero.Anterior = Ultimo;  // se señala que antes del primero esta el ultimo
                }
                Console.WriteLine("╔══════════════════════╗");
                Console.WriteLine($"║ Se insertó: {Ultimo.Dato,-8} ║");  // se muestra el dato ingresado
                Console.WriteLine($"╚══════════════════════╝");
            }catch(Exception e) {  // muestra mensaje si se introdujo un dato incorrecto
                Console.WriteLine("╔══════════════════════════════════════════════════════╗");
                Console.WriteLine("║               MENSAJE DE ERROR                       ║");
                Console.WriteLine("╠══════════════════════════════════════════════════════╣");
                Console.WriteLine("║ Ocurrió un error. Por favor, inténtalo de nuevo.     ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════╝"); 
            }
        }

        public void desplegarLista()
        {
            Nodo actual = new Nodo();  // se crea nodo actual para poder recorrer la lista
            actual = Primero;

            
            Console.WriteLine("╔═══════════════════════════╗");
            Console.WriteLine($"║     LISTA DESPLEGADA      ║");
            Console.WriteLine($"╠═══════════════════════════╣");
            
            



            if (Primero != null)  // si hay datos en la lista
            {
                while (actual != null)  // mientras el dato actual no sea null
                {
                    Console.WriteLine($"║   *** {actual.Dato,-19} ║");  // se muestra el dato actual
                    actual = actual.Siguiente;  // el dato actual se convierte en el siguiente

                    if(actual == Primero)  // if para verificar que solo se muestre una vez la lista
                    {
                        break;  // si ya se recorrio la lista rompe el ciclo
                    }
                }
            }
            else  // si no hay dato en la lista
            {
                Console.WriteLine($"║ No hay datos en la lista. ║");  
            }
            Console.WriteLine($"╚═══════════════════════════╝");

        }

        public void eliminarNodo()
        {
            Nodo actual = new Nodo();  // se crea el nodo actual para recorrer la lista
            actual = Primero;
            Nodo anterior = new Nodo();  // se crea el nodo anterior para saber cual estaba antes
            anterior = null;
            Nodo siguiente = new Nodo();  // se crea el nodo siguiente para hacer la union al quitar el nodo
            siguiente = null;
            bool Encontrado = false;  // variable para llevar el control si se encontro
            Console.WriteLine("\r\n\r\n-------Ingrese el dato del nodo a buscar para eliminar: ");
            try { // try para evitar errores de introduccion de datos
            int nodoBuscado = int.Parse(Console.ReadLine());  // se solicita el dato a eliminar
            if (Primero != null)  // si la lista tiene datos
            {
                while (actual != null && Encontrado != true)  // mientras no se haya recorrido toda la lista o no se haya encontrado el dato
                {
                    if (actual.Dato == nodoBuscado)  // si se encontro el dato buscado
                    {
                        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
                        Console.WriteLine($"║ El nodo con el dato {nodoBuscado,-27} Encontrado ║");

                        if (actual == Primero)  // si el dato buscado es el primero
                        {
                            Ultimo.Siguiente = Primero.Siguiente;  // actualizar el siguiente del ultimo
                            Primero = Primero.Siguiente;  // se elimina
                            Primero.Anterior = Ultimo;  // se colocar que el anterior al primero es el ultimo
                               
                        }
                        else if (actual == Ultimo)  // si es el ultimo
                        {
                            anterior.Siguiente = Primero; // el anterior apunta a null
                            Ultimo = anterior;  // se elimina
                                Primero.Anterior = Ultimo; // actualizar el anterior del primero
                        }
                        else  // si el nodo a eliminar no es ni el primero ni el ultimo
                        {
                            anterior.Siguiente = actual.Siguiente; // se elimina el nodo actual
                            siguiente.Anterior = actual.Anterior;  // se coloca que el anterior al siguiente es el anterior al actual

                        }
                        Console.WriteLine($"╠════════════════════════════════════════════════════════════╣");
                        Console.WriteLine($"║                      Nodo Eliminado                        ║");
                        Console.WriteLine($"╚════════════════════════════════════════════════════════════╝");
                        Encontrado = true;
                    }
                    anterior = actual;  // se pasa al siguiente nodo
                    actual = actual.Siguiente;  //  se pasa al siguiente nodo
                    siguiente = actual.Siguiente;  // se pone el sigguiente del actual

                        if (actual == Primero)  // if para verificar que solo se recorra una vez la lista
                        {
                            break;
                        }
                }
                if (!Encontrado)  // si no se encontro el nodo
                {
                    Console.WriteLine("╔═══════════════════════════╗");
                    Console.WriteLine($"║    Nodo no encontrado     ║");
                    Console.WriteLine($"╚═══════════════════════════╝");
                }
            }
        }catch (Exception ex)  // mensaje de error si se introdujo un dato erroneo
            {
                Console.WriteLine("╔══════════════════════════════════════════════════════╗");
                Console.WriteLine("║               MENSAJE DE ERROR                       ║");
                Console.WriteLine("╠══════════════════════════════════════════════════════╣");
                Console.WriteLine("║ Ocurrió un error. Por favor, inténtalo de nuevo.     ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            }

                
            
            
        }

       



    }
}
