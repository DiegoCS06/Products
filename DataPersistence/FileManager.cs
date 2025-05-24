using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {
        //Metodo retorna lista de productos del
        //Archivo de texto
        public List<Product> ReadProducts()
        {
            //DESARROLLAR
            //LEER LA LISTA DE PRODUCTOS DE UN TXT Y CARGARLO EN LISTA
            var products = new List<Product>();
            return products;
        }

        public void SaveProduct(Product product)
        {
            //DESARROLLAR GUARDAR PRODUCTO EN UN TXT
        }
    }
}
