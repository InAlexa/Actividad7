using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> listaDeNumeros = new List<int>();

    static void Main()
    {
        int cat = 0; // variable creada para el menú
        while (cat == 0)
        {
            try
            {
                Menu();
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        CrearListaDeNumeros();
                        break;
                    case 2:
                        CalcularMedia();
                        break;
                    case 3:
                        CalcularMediana();
                        break;
                    case 4:
                        CalcularModa();
                        break;
                    case 5:
                        CalcularDesviacionEstandar();
                        break;
                    case 6:
                        CrearListaDeNumeros();
                        break;
                    case 7:
                        Console.WriteLine("Has salido del programa.");
                        cat = 1;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una de las opciones dentro del menú.");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Error: No ha ingresado un número entero.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Ha ocurrido un error.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menú");
        Console.WriteLine("1. Ingresar la lista de números");
        Console.WriteLine("2. Calcular la media");
        Console.WriteLine("3. Calcular la mediana");
        Console.WriteLine("4. Calcular la moda");
        Console.WriteLine("5. Calcular la desviación estándar");
        Console.WriteLine("6. Cambiar los números en la lista");
        Console.WriteLine("7. Salir");
        Console.WriteLine("Ingrese una opción: ");
    }

    static void CrearListaDeNumeros()
    {
        int catList = 0;
        while (catList == 0) // con este while puedo controlar los valor que ingresan en "cantidad" y evitar que truene 
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingresa la cantidad de datos a agregar:");
                int cantidad = int.Parse(Console.ReadLine());
                if (cantidad > 0)
                {
                    listaDeNumeros.Clear(); // borra los datos dentro de la lista guardados anteriormente

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("Ingrese un valor: ");
                        int valor = int.Parse(Console.ReadLine());
                        listaDeNumeros.Add(valor);
                    }

                    Console.WriteLine("Los valores en la lista son:");
                    foreach (int i in listaDeNumeros)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    catList = 1;
                }
                else if (cantidad <= 0)
                {
                    Console.WriteLine("La cantidad debe ser mayor a cero.");
                    Console.ReadKey();
                }
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Error: No ha ingresado un número entero.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Ha ocurrido un error.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        Console.ReadKey();
    }
    static void CalcularMedia()
    {
        if (listaDeNumeros.Count == 0) // este if se utiliza cuando no hayan valores dentro de la lista
        {
            Console.WriteLine("La lista está vacía.");
            return; // retorna este texto si se cumple la condición
        }

        double suma = 0;
        foreach (int numero in listaDeNumeros)
        {
            suma += numero;
        }

        double media = suma / listaDeNumeros.Count;
        Console.WriteLine("La media es: " + media);
    }

    static void CalcularMediana()
    {
        if (listaDeNumeros.Count == 0) // este if se utiliza cuando no hayan valores dentro de la lista
        {
            Console.WriteLine("La lista está vacía.");
            return; // retorna este texto si se cumple la condición
        }

        listaDeNumeros.Sort();
        double mediana;
        int cuenta = listaDeNumeros.Count;

        if (cuenta % 2 == 0)
        {
            int mitad1 = listaDeNumeros[cuenta / 2 - 1];
            int mitad2 = listaDeNumeros[cuenta / 2];
            mediana = (mitad1 + mitad2) / 2.0;
        }
        else
        {
            mediana = listaDeNumeros[cuenta / 2];
        }

        Console.WriteLine("La mediana es: " + mediana);
    }

    static void CalcularModa()
    {
        Console.WriteLine("No lo supe hacer.");
    }

    static void CalcularDesviacionEstandar()
    {
        Console.WriteLine("Tampoco lo supe hacer");
    }
}