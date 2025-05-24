using Entities;
using System;
using System.Collections.Generic;

namespace BussinesLogic
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct()
        {
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

            products.Add(producto);
            Console.WriteLine("Producto añadido correctamente.\n");
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
