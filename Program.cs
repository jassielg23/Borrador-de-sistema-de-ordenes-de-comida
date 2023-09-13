using System;
using System.Collections.Generic;

class Platillo
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Platillo(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class Categoria
{
    public string Nombre { get; set; }
    public List<Platillo> Platillos { get; set; }

    public Categoria(string nombre)
    {
        Nombre = nombre;
        Platillos = new List<Platillo>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Categoria entradas = new Categoria("Entradas");
        Categoria platosPrincipales = new Categoria("Platos Principales");
        Categoria postres = new Categoria("Postres");

        entradas.Platillos.Add(new Platillo("Ensalada César", 7.99m));
        entradas.Platillos.Add(new Platillo("Sopa de Tomate", 5.99m));

        platosPrincipales.Platillos.Add(new Platillo("Filete de Salmón", 15.99m));
        platosPrincipales.Platillos.Add(new Platillo("Pollo a la Parrilla", 12.99m));

        postres.Platillos.Add(new Platillo("Pastel de Chocolate", 6.99m));
        postres.Platillos.Add(new Platillo("Helado de Vainilla", 4.99m));

        while (true)
        {
            Console.WriteLine("Seleccione el tipo de platillo a ver:");
            Console.WriteLine("1. Entradas");
            Console.WriteLine("2. Platos Principales");
            Console.WriteLine("3. Postres");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarCategoria(entradas);
                    break;

                case "2":
                    MostrarCategoria(platosPrincipales);
                    break;

                case "3":
                    MostrarCategoria(postres);
                    break;

                case "4":
                    Environment.Exit(0); // Salir del programa
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void MostrarCategoria(Categoria categoria)
    {
        Console.WriteLine($"Menú de {categoria.Nombre}:\n");

        foreach (var platillo in categoria.Platillos)
        {
            Console.WriteLine($"{platillo.Nombre} - ${platillo.Precio}");
        }

        Console.WriteLine("\nPresione Enter para volver al menú principal.");
        Console.ReadLine();
    }
}
