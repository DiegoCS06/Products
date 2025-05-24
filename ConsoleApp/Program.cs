using BussinesLogic;
using Entities;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var manager = new ProductManager();
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
                    agregarProducto();
                    break;

                case 2:
                    listarProductos();
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

    static void agregarProducto()
    {
        var manager = new ProductManager();

        Console.WriteLine("Ingrese la ID del Producto a añadir: ");
        int idProducto = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre del Producto a añadir: ");
        string nombreProducto = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del Producto a añadir: ");
        double precioProducto = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el stock del Producto a añadir: ");
        int stockProducto = int.Parse(Console.ReadLine());

        var producto = new Product
        {
            Id = idProducto,
            Name = nombreProducto,
            Price = precioProducto,
            Stock = stockProducto
        };

        try
        {
            manager.AddProduct(producto);
            Console.WriteLine("Producto añadido correctamente.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void listarProductos()
    {
        var manager = new ProductManager();

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
    }

}
