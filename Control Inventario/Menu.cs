using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    internal class Menu
    {
        //Menu principal
        public static void principal()
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Ingresar articulos");
                Console.WriteLine("3- Modificar Articulos");
                Console.WriteLine("4- Borrar Articulos");
                Console.WriteLine("5- Consultar Articulos");
                Console.WriteLine("6- Salir");

                opcion =int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1: Articulos.inicializarArreglos(); break;
                    case 2: Articulos.IngresarProductos(); break;
                    case 3: Articulos.modificarProductos(); break;
                    case 4: Articulos.borrarProductos(); break;
                    case 5: Articulos.consultarProductos(); break;
                    case 6: Console.WriteLine("Saliendo del sistema"); break;
                    default: Console.WriteLine("*** Opcion Incorrecta ***"); break;


                }

            } while (opcion != 6); //mientras opcion sea diferente de 6 ==> TRUE
        }
    }
}
