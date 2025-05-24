using Entities;

namespace Entities
{

    //Objetos de tipo DTO
    //Data Transfer Object
    //POJOs Plain Old Java Object
    //Objetos sin acciones, solo con atributos
    public class Product : ProductBase
    {
        public double Price { get; set; }

        public int Stock { get; set; }
    }
}
