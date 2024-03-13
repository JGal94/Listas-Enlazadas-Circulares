using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasenlazadas
{
    internal class Pantalla
    {
        public int Menu()  // se muestra el menu y se solicita una opcion
        {

            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine($"║                  MENÚ PRINCIPAL                  ║");
            Console.WriteLine($"╠══════════════════════════════════════════════════╣");
            Console.WriteLine($"║ 1. Agregar dato a la lista                       ║");
            Console.WriteLine($"║ 2. Desplegar lista                               ║");
            Console.WriteLine($"║ 3. Eliminar dato de la lista                     ║");
            Console.WriteLine($"║ 0. Salir                                         ║");
            Console.WriteLine($"╚══════════════════════════════════════════════════╝");

            Console.Write("Ingrese una opción: ");
            try  // ty por si se introduce un dato incorrecto
            {
                return int.Parse(Console.ReadLine());
            }catch(Exception e) {   // retorna una opcion fuera del menu para que muestre la opcion default del switch case        
                return 5;
            }

        }

        public void Intro(int i)  // muestra en pantalla esto al iniciar el programa
        {
            Console.Clear();
            Console.WriteLine("       $$$$$$\\        $$$$$$$$\\                                            \r\n      $$  __$$\\       \\__$$  __|                                           \r\n      \\__/  $$ |         $$ | $$$$$$\\   $$$$$$\\   $$$$$$\\   $$$$$$\\        \r\n       $$$$$$  |         $$ | \\____$$\\ $$  __$$\\ $$  __$$\\  \\____$$\\       \r\n      $$  ____/          $$ | $$$$$$$ |$$ |  \\__|$$$$$$$$ | $$$$$$$ |      \r\n      $$ |               $$ |$$  __$$ |$$ |      $$   ____|$$  __$$ |      \r\n      $$$$$$$$\\          $$ |\\$$$$$$$ |$$ |      \\$$$$$$$\\ \\$$$$$$$ |      \r\n      \\________|         \\__| \\_______|\\__|       \\_______| \\_______|      \r\n                                                                           \r\n                                                                           \r\n                                                                           \r\n   $$$$$\\                                      $$$$$$\\  $$\\    $$\\         \r\n   \\__$$ |                                    $$  __$$\\ $$ |   $$ |        \r\n      $$ |$$\\   $$\\  $$$$$$\\  $$$$$$$\\        $$ /  \\__|$$ |   $$ |        \r\n      $$ |$$ |  $$ | \\____$$\\ $$  __$$\\       $$ |$$$$\\ \\$$\\  $$  |        \r\n$$\\   $$ |$$ |  $$ | $$$$$$$ |$$ |  $$ |      $$ |\\_$$ | \\$$\\$$  /         \r\n$$ |  $$ |$$ |  $$ |$$  __$$ |$$ |  $$ |      $$ |  $$ |  \\$$$  /          \r\n\\$$$$$$  |\\$$$$$$  |\\$$$$$$$ |$$ |  $$ |      \\$$$$$$  |   \\$  /           \r\n \\______/  \\______/  \\_______|\\__|  \\__|       \\______/     \\_/            \r\n                                                                   ");
            Thread.Sleep(i);  // se pone en reposo durante el tiempo de i
            Console.Clear();  // se limpia la pantalla y se continua el programa
        }
        
    }
}
