using BussinesLogic;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var manager = new ProductManager(); // ✅ UNA instancia que guarda la lista
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("BIENVENIDO AL MENÚ.");
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Agregar Productos");
            Console.WriteLine("2. Listar Productos");
            Console.WriteLine("3. Salir del Programa");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Opción inválida.\n");
                continue;
            }

            switch (option)
            {
                case 1:
                    manager.AddProduct();
                    break;

                case 2:
                    var productos = manager.GetProducts();
                    if (productos.Count == 0)
                    {
                        Console.WriteLine("No hay productos registrados.\n");
                    }
                    else
                    {
                        foreach (var producto in productos)
                        {
                            Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Name}, Precio: {producto.Price}, Stock: {producto.Stock}\n");
                        }
                    }
                    break;

                case 3:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Ingrese una opción válida.\n");
                    break;
            }
        }
    }
}
