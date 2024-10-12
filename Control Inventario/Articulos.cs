using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    internal class Articulos
    {
        public static int[] id = new int[3]; //codigo del articulo
        public static string[] nombre = new string[3]; // nombre del articulo
        public static int[] precio = new int[3]; //precio del articulo
        public static int[] cantidad = new int[3]; //cantidad de articulos
        public static string[] bodega = new string[3]; //nombre de la bodega

        //metodo para inicializar arreglos

        public static void inicializarArreglos()
        {
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                nombre[i] = "";
                precio[i] = 0;
                cantidad[i] = 0;
                bodega[i] = "";

            }
            Console.WriteLine("Los arreglos han sido actualizados");
            Console.Clear();
        }

        public static void IngresarProductos()
        {
            int indice = 0;
            while (indice < id.Length)
            {

                Console.WriteLine("Digite un codigo: ");
                id[indice] = int.Parse(Console.ReadLine());
                Console.Write("Digite un articulo: ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite el precio: ");
                precio[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad: ");
                cantidad[indice] = int.Parse(Console.ReadLine());
                Console.Write("Digite el nombre de la bodega: ");
                bodega[indice] = Console.ReadLine();
                indice++;
                Console.Clear();
            }
            Console.WriteLine("Los articulos han sido ingresados");
        }

        public static void consultarProductos()
        {
            Console.Clear();
            Console.WriteLine("*** REPORTE DE ARTICULOS ***");
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]} Precio: {precio[i]} Cantidad: {cantidad[i]} Bodega: {bodega[i]} ");
            }
            Console.WriteLine("*** FIN DEL REPORTE ***");
        }

        public static void modificarProductos()
        {
            Console.Clear();
            Console.Write("Digite el codigo del articulo que desea modificiar: ");
            int nuevocodigo = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0;i < id.Length;i++) 
                {
                if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]} Precio: {precio[i]} Cantidad: {cantidad[i]} Bodega: {bodega[i]}");
                    Console.Write("Digite un nombre nuevo: ");
                    nombre[i] = Console.ReadLine();

                    Console.Write("Digite el precio nuevo: ");
                    precio[i] = int.Parse(Console.ReadLine());

                    Console.Write("Digite la cantidad nueva: ");
                    cantidad[i] = int.Parse(Console.ReadLine());

                    Console.Write("Digite el nombre nuevo de la bodega: ");
                    bodega[i] = Console.ReadLine();

                    encontrado = true;
                    Console.WriteLine("Producto modificado correctamente.");
                    break;

                }
                if (!encontrado)
                    Console.WriteLine("El producot con el codigo ingresado no se encuentra.");


                }

        }

        public static void borrarProductos()
        {
            Console.Clear();
            Console.Write("Digite el codigo del articulo que desee borrar: ");
            int codigoABorrar = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == codigoABorrar)
                {
                    id[i] = 0;
                    nombre[i] = "";
                    precio[i] = 0;
                    cantidad[i] = 0;
                    bodega[i] = "";
                    encontrado = true;
                    Console.WriteLine("Producto borrado correctamente.");
                    break;
                }
            }
            if (!encontrado)
                Console.WriteLine("El producto con el codigo ingresado no se encontro.");
        }


    }

}
