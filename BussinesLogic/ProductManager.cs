using DataPersistence;
using Entities;
using System;
using System.Collections.Generic;

namespace BussinesLogic
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product producto)
        {
            //Validaciones
            if (String.IsNullOrEmpty(producto.Name))
            {
                throw new Exception("El nombre no puede estar vacío.");
            }

            if (producto.Price < 1)
            {
                throw new Exception("El precio debe sar mayor a 0");
            }

            if(producto.Stock < 1)
            {
                throw new Exception("El stock debe ser mayor a 0");
            }

            var fm = new FileManager();
            fm.SaveProduct(producto);

        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
