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
                    Console.WriteLine("Ingresa tu nombre: ");
                    string input2 = Console.ReadLine();
                    // Mostrar el string en minúsculas y en mayúsculas
                    Console.WriteLine("Minúsculas: " + input2.ToLower());
                    Console.WriteLine("Mayúsculas: " + input2.ToUpper());
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.WriteLine("Ingresa una palabra o frase: ");
                    string input3 = Console.ReadLine();
                    Console.WriteLine("Ingresa una letra: ");
                    char letter = Console.ReadLine()[0];
                    // Contar las ocurrencias de la letra en el string
                    int count = 0;
                    for (int i = 0; i < input3.Length; i++)
                    {
                        if (input3[i] == letter)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("La letra '" + letter + "' se repite " + count + " veces.");
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.WriteLine("Ingresa el primer string: ");
                    string input4 = Console.ReadLine();

                    Console.WriteLine("Ingresa el segundo string: ");
                    string input5 = Console.ReadLine();

                    Console.WriteLine("Ingresa el número de veces que quieres repetir los strings: ");
                    int repeat = int.Parse(Console.ReadLine());

                    // Repetir los strings el número de veces indicado
                    for (int i = 0; i < repeat; i++)
                    {
                        Console.Write($"{input4} ");
                        Console.Write($"{input5} ");
                    }
                    Console.ReadKey();
                            return true;
                case "5":
                    Console.WriteLine("Ingresa una palabra o frase: ");
                    string input6 = Console.ReadLine();

                    Console.WriteLine("El string con las letras repetidas es: ");

                    // Volver a escribir el string repitiendo cada letra
                    foreach (char letter1 in input6)
                    {
                        Console.Write(new string(letter1, 2));
                    }

                    Console.ReadKey();
                    return true;
                case "6":
                    Console.WriteLine("Ingresa el primer string: ");
                    string input7 = Console.ReadLine();
                    Console.WriteLine("Ingresa el segundo string: ");
                    string input8 = Console.ReadLine();
                    // Eliminar las apariencias del segundo string del primero
                    string result = input7.Replace(input8, "");
                    Console.WriteLine("El resultado es: " + result);
                    Console.ReadKey();
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
