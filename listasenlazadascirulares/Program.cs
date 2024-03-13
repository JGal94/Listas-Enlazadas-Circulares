using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasenlazadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se instancias las clases que se usaran
            Listas general = new Listas();  
            Pantalla pantalla = new Pantalla();
            Console.ForegroundColor = ConsoleColor.Green;
            pantalla.Intro(4000); // se envia un dato al metodo intro de la clase pantalla
           

            do // un do while para correr en loop el menu
            {   
                switch (pantalla.Menu()) // se toma el valor que retorne el metodo menu de la clase pantalla
                {
                    case 1:  // si se presiona 1

                        String valor = "S";
                        while (valor.ToUpper() == "S") // se pone el mayuscula el dato ingresado por si digitan s 
                        {
                            Console.Clear();  // se limpia la pantalla
                            general.insertarNodo(); // se llama el metodo insertar nodo
                            Console.WriteLine("╔═══════════════════════════════════════╗");
                            Console.WriteLine($"║    Desea ingresar mas nodos? (S/N)    ║");
                            Console.WriteLine($"╠═══════════════════════════════════════╣");
                            valor = Console.ReadLine();
                        }
                        Console.Clear();
                        
                        general.desplegarLista();// se llama el metodo desplegar lista de la clase listas
                        

                        break;  // rompe
                    case 2:  // si se presiona 2
                        Console.Clear();  // se limpia la pantalla
                        
                        general.desplegarLista();  // se llama el metodo deslplegar lista de la clase listas
                        
                        break;  // rompe
                    case 3:  // si se presiona 3
                        Console.Clear();  // se limpia la pantalla
                        
                        general.eliminarNodo();  // se llama el metodo eliminar nodo de la clase listas
                        
                        break;// rompe
                    case 0:  // si se presiona 0
                        Console.Clear();  // se limpia la pantalla
                        Environment.Exit(0);  // se cierra el programa
                        break;// rompe
                    default:  // si se presiona algo fuera de las opciones
                        Console.Clear();

                        Console.WriteLine("╔═════════════════════════════╗");
                        Console.WriteLine($"║    MENSAJE DEL SISTEMA      ║");
                        Console.WriteLine($"╠═════════════════════════════╣");
                        Console.WriteLine($"║      Opción invalida        ║");
                        Console.WriteLine($"╚═════════════════════════════╝");

                        break;// rompe


                }




            } while (true);  // se cumple mientras sea true es decir siempre
        }
    }
}
