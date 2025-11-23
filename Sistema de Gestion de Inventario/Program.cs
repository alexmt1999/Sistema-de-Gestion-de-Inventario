using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Gestion_de_Inventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, a El Aventurero S.L.");
            Console.WriteLine("¿Dígame, cúal es su nombre?");

            string userName = Console.ReadLine();

            Console.WriteLine($"Es un placer tenerle con nosotros, {userName}");
            Console.WriteLine($"{userName}, A continuación le enseñaré un menú principal donde podrá modificar nuestra base de datos" +
                $" para agregar, listar, buscar, eliminar o actualizar productos: \n");
            Console.WriteLine("1. Agregar Producto: ");


            try
            {
                using (var conexion = new InventarioContext())
                {
                    if (conexion.Database.CanConnect())
                    {
                        Console.WriteLine("Conexión establecida con la base de datos ✅");
                    }
                }
                bool salir = false;

                while (!salir)
                {
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("------------------MAIN MENU DATABASE----------------------");
                    Console.WriteLine("Pulse 1 para agregar producto a la base de datos");
                    Console.WriteLine("Pulse 2 para listar y mostrar todos los productos de la base de datos");
                    Console.WriteLine("Pulse 3 para buscar un producto por su nombre");
                    Console.WriteLine("Pulse 4 para actualizar el stock de productos");
                    Console.WriteLine("Pulse 5 para eliminar un producto de la base de datos");
                    Console.WriteLine("Pulse 6 para cerrar la aplicacion o escriba 'salir'.");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            using (var insertar = new InventarioContext())
                            {
                                Console.WriteLine("Introduzca el nombre del producto");
                                
                                string nombre = Console.ReadLine();

                                Console.WriteLine("Introduzca el precio del producto");

                                decimal precio = decimal.Parse(Console.ReadLine());

                                Console.WriteLine("Introduzca el stock actual del producto");

                                int stock = int.Parse(Console.ReadLine());

                                var nuevoProducto = new Producto  //Creación de un nuevo objeto producto
                                {
                                    Name = nombre,
                                    Price = precio,
                                    Stock = stock
                                };

                                insertar.Productos.Add(nuevoProducto); //añadir el producto a la base de datos

                                insertar.SaveChanges(); //Guardar cambios

                                int resultado = insertar.SaveChanges(); //Introducimos en la variable resultado el numero de filas insertadas

                                if(resultado > 0)
                                {
                                    Console.WriteLine("El producto ha sido agregado exitosamente ✅.");
                                }
                                else
                                {
                                    Console.WriteLine("No se pudo insertar el producto 🙅‍");
                                }
                            }
                            break;
                        case "2":
                            using (var mostrar = new InventarioContext())
                            {
                                //SELECT * FROM Productos
                                var listaProductos = mostrar.Productos.ToList();

                                foreach(var )

                            }

                        case "3":

                        case "4":

                        case "5":

                         case "6":
                            salir = true;
                            break;

                                default:
                                    Console.WriteLine("Selecciona una opción válida");
                                    break;
                                }






                }
                using (var consultas = new InventarioContext())
                {
                    var listaProductos = consultas.Productos.ToList();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos ❎. Revise la configuración introducida🔍.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            


        }
    }
}
