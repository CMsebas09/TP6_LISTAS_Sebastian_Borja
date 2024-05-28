// Directiva para incluir el espacio de nombres System, que contiene las clases fundamentales del framework de .NET
using System;
// Directiva para incluir el espacio de nombres System.Collections.Generic, que contiene las clases para trabajar con colecciones genéricas
using System.Collections.Generic;

// Declaración del espacio de nombres Frutas
namespace Frutas
{
    // Definición de la clase Fruta
    class Fruta
    {
        // Propiedades públicas para el nombre y el color de la fruta
        public string Nombre { get; set; }
        public string Color { get; set; }

        // Constructor para inicializar el nombre y el color de la fruta
        public Fruta(string nombre, string color)
        {
            Nombre = nombre;
            Color = color;
        }

        // Sobrescritura del método ToString para obtener una representación de cadena de la fruta
        public override string ToString()
        {
            return $"{Nombre} ({Color})";
        }
    }

    // Definición de la clase Program
    class Program
    {
        // Método principal que se ejecuta al iniciar el programa
        static void Main(string[] args)
        {
            // Crear una lista de frutas para almacenar objetos de la clase Fruta
            List<Fruta> frutas = new List<Fruta>();

            // Variable booleana para controlar si se debe continuar con el bucle del menú
            bool continuar = true;

            // Bucle while que muestra un menú al usuario y ejecuta las opciones seleccionadas
            while (continuar)
            {
                // Mostrar el menú en la consola
                Console.WriteLine("\n-----Menú-----");
                Console.WriteLine("1. Añadir fruta");
                Console.WriteLine("2. Eliminar fruta");
                Console.WriteLine("3. Mostrar lista de frutas");
                Console.WriteLine("4. Salir");

                // Solicitar al usuario que elija una opción
                Console.Write("\nElija una opción: ");
                string opcion = Console.ReadLine();

                // Estructura switch para manejar las diferentes opciones del menú
                switch (opcion)
                {
                    // Opción 1: Añadir fruta
                    case "1":
                        Console.Write("Ingrese el nombre de la fruta: ");
                        string nombreFruta = Console.ReadLine();
                        Console.Write("Ingrese el color de la fruta: ");
                        string colorFruta = Console.ReadLine();
                        // Crear un nuevo objeto Fruta y añadirlo a la lista de frutas
                        frutas.Add(new Fruta(nombreFruta, colorFruta));
                        Console.WriteLine("Fruta añadida con éxito.");
                        break;

                    // Opción 2: Eliminar fruta
                    case "2":
                        Console.Write("Ingrese el nombre de la fruta a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        // Buscar la fruta en la lista por su nombre
                        Fruta frutaEliminar = frutas.Find(f => f.Nombre.Equals(nombreEliminar, StringComparison.OrdinalIgnoreCase));
                        if (frutaEliminar != null)
                        {
                            // Si se encuentra la fruta, eliminarla de la lista
                            frutas.Remove(frutaEliminar);
                            Console.WriteLine("Se elimino la fruta exitosamente.");
                        }
                        else
                        {
                            // Si la fruta no se encuentra, mostrar un mensaje
                            Console.WriteLine("La fruta no se ecuentra en la lista.");
                        }
                        break;

                    // Opción 3: Mostrar lista de frutas
                    case "3":
                        Console.WriteLine("\nLista de frutas:");
                        // Iterar sobre la lista de frutas y mostrar cada una en la consola
                        foreach (Fruta fruta in frutas)
                        {
                            Console.WriteLine(fruta);
                        }
                        break;

                    // Opción 4: Salir del programa
                    case "4":
                        continuar = false;
                        break;

                    // Opción por defecto: Manejar una opción no válida
                    default:
                        Console.WriteLine("Eleccion invalida, verifique de nuevo");
                        break;
                }
            }

            // Mensaje de despedida al salir del bucle del menú
            Console.WriteLine("Gracias por ocupar mi programa UwU");
        }
    }
}
