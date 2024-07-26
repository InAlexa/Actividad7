using System;

static void Main()
{
    int cat = 0;
    while (cat == 0)
    {
        try
        {
            Menu();
            Console.WriteLine("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.ReadKey();
                    break;
                case 2:
                    Console.ReadKey();
                    break;
                case 3:
                    Console.ReadKey();
                    break;
                case 4:
                    Console.ReadKey();
                    break;
                case 5:
                    Console.ReadKey();
                    break;
                case 6:
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Has salido del programa.");
                    cat = 1;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ingrese una de las opciones dentro del menú.");
                    Console.ReadKey();
                    break;
            }
        }
        catch (FormatException ex)
        {
            Console.Clear() ;
            Console.WriteLine("Error: No ha ingresado un número entero.");
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
        catch(Exception ex)
        {
            Console.Clear();
            Console.WriteLine("Ha ocurrido un error.");
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
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
}
Main();
