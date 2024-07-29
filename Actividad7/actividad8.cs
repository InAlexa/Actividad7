using System;
using System.Collections.Generic;
using ClaseParaActividad8;

namespace Actividad7
{
    class Program
    {
        static Estadisticas estadisticas = new Estadisticas();

        static void Main()
        {
            int cat = 0;
            while (cat == 0)
            {
                try
                {
                    estadisticas.Menu();
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

        static void CrearListaDeNumeros()
        {
            int catList = 0;
            while (catList == 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa la cantidad de datos a agregar:");
                    int cantidad = int.Parse(Console.ReadLine());
                    if (cantidad > 0)
                    {
                        List<int> valores = new List<int>();
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Ingrese un valor: ");
                            int valor = int.Parse(Console.ReadLine());
                            valores.Add(valor);
                        }

                        estadisticas.CrearListaDeNumeros(cantidad, valores);

                        Console.WriteLine("Los valores en la lista son:");
                        foreach (int i in estadisticas.ListaDeNumeros)
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
            try
            {
                double media = estadisticas.CalcularMedia();
                Console.WriteLine("La media es: " + media);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CalcularMediana()
        {
            try
            {
                double mediana = estadisticas.CalcularMediana();
                Console.WriteLine("La mediana es: " + mediana);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CalcularModa()
        {
            try
            {
                List<int> modas = estadisticas.CalcularModa();
                Console.WriteLine("La moda es: " + string.Join(", ", modas));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CalcularDesviacionEstandar()
        {
            try
            {
                double desviacionEstandar = estadisticas.CalcularDesviacionEstandar();
                Console.WriteLine("La desviación estándar es: " + desviacionEstandar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}