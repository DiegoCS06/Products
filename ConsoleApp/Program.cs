public class Program {

    public static void Main(string[] args)
    {

        Console.WriteLine("BIENVENIDO AL MENÚ.");
        Console.WriteLine("Seleccione una opción: ");
        Console.WriteLine("1. Agregar Productos");
        Console.WriteLine("2. Listar Productos");
        Console.WriteLine("3. Salir del Programa");

        var option=Int32.Parse(Console.ReadLine());

        switch (option) 
        {
            case 1:
                Console.WriteLine("Digite la información del Producto a añadir.");
                break;

            case 2:
                Console.WriteLine("Listado de Productos existentes: ");
                break;

            case 3:
                Console.WriteLine("Saliendo del Programa.");
                break;

            default: Console.WriteLine("Ingrese una opción válida.");
                break;
        }
    } 
}