using System;

namespace ConsoleMenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar el menú principal
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1) Devolver si el string es un palíndromo");
            Console.WriteLine("2) Escribir su nombre todo en mayúsculas y todo en minúsculas");
            Console.WriteLine("3) Devolver el número de ocurrencias de una letra");
            Console.WriteLine("4) Repetir las veces que desee dos strings");
            Console.WriteLine("5) Dado un string repetir las ocurrencias de sus letras");
            Console.WriteLine("6) Dados dos strings, borrar las apariencias del segundo en el primero");
            Console.WriteLine("7) Salir");
            Console.Write("Opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Ingresa una palabra o frase: ");
                    string input = Console.ReadLine();
                    // Quitar espacios y poner todo en minúsculas
                    input = input.Replace(" ", "").ToLower();
                    // Verificar si el string es igual a su reverso
                    bool isPalindrome = true;
                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        if (input[i] != input[input.Length - i - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        Console.WriteLine("La palabra o frase es un palíndromo.");
                    }
                    else
                    {
                        Console.WriteLine("La palabra o frase NO es un palíndromo.");
                    }
                    Console.ReadKey();
                    return true;
                case "2":
                    
                    return true;
                case "3":

                    return true;
                case "4":

                    return true;
                case "5":

                    return true;
                case "6":

                    return true;
                case "7":
                    return false;
                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    return true;
            }
        }
    }
}
