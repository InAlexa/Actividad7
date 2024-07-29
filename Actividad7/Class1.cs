using System;
using System.Collections.Generic;
using System.Linq;

namespace ClaseParaActividad8
{
    public class Estadisticas
    {
        public List<int> ListaDeNumeros { get; private set; }

        public Estadisticas()
        {
            ListaDeNumeros = new List<int>();
        }

        public void CrearListaDeNumeros(int cantidad, List<int> valores)
        {
            if (cantidad > 0)
            {
                ListaDeNumeros.Clear();
                ListaDeNumeros.AddRange(valores);
            }
        }

        public double CalcularMedia()
        {
            if (ListaDeNumeros.Count == 0)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }

            double suma = ListaDeNumeros.Sum();
            return suma / ListaDeNumeros.Count;
        }

        public double CalcularMediana()
        {
            if (ListaDeNumeros.Count == 0)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }

            ListaDeNumeros.Sort();
            int cuenta = ListaDeNumeros.Count;
            if (cuenta % 2 == 0)
            {
                int mitad1 = ListaDeNumeros[cuenta / 2 - 1];
                int mitad2 = ListaDeNumeros[cuenta / 2];
                return (mitad1 + mitad2) / 2.0;
            }
            else
            {
                return ListaDeNumeros[cuenta / 2];
            }
        }

        public List<int> CalcularModa()
        {
            if (ListaDeNumeros.Count == 0)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }

            Dictionary<int, int> frecuencia = new Dictionary<int, int>();

            foreach (int numero in ListaDeNumeros)
            {
                if (frecuencia.ContainsKey(numero))
                {
                    frecuencia[numero]++;
                }
                else
                {
                    frecuencia[numero] = 1;
                }
            }

            int maximaFrecuencia = frecuencia.Values.Max();
            List<int> modas = new List<int>();

            foreach (var par in frecuencia)
            {
                if (par.Value == maximaFrecuencia)
                {
                    modas.Add(par.Key);
                }
            }

            return modas;
        }

        public double CalcularDesviacionEstandar()
        {
            if (ListaDeNumeros.Count == 0)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }

            double media = ListaDeNumeros.Average();
            double sumaCuadrados = ListaDeNumeros.Select(num => Math.Pow(num - media, 2)).Sum();
            return Math.Sqrt(sumaCuadrados / ListaDeNumeros.Count);
        }

        public void Menu()
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
    }

}