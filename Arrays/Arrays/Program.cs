internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Calcular el máximo");
            Console.WriteLine("2. Calcular el mínimo");
            Console.WriteLine("3. Calcular la mediana");
            Console.WriteLine("4. Calcular la media");
            Console.WriteLine("5. Ordenar números de menor a mayor");
            Console.WriteLine("6. Calcular el mínimo");
            Console.WriteLine("7. Calcular el mínimo");
            Console.WriteLine("8. Salir");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    int max = int.MinValue; // inicializamos max con el valor mínimo posible para int
                    int[] numbers = new int[10]; // Declaramos un array de 10 elementos
                    Console.WriteLine("Introduce 10 números para calcular el máximo:");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = int.Parse(Console.ReadLine());
                        if (numbers[i] > max)
                        {
                            max = numbers[i];
                        }
                    }
                    Console.WriteLine("El máximo es: " + max);
                    break;
                case "2":
                    int min = int.MaxValue; // inicializamos min con el valor máximo posible para int
                    int[] numbers1 = new int[10]; // Declaramos un array de 10 elementos
                    Console.WriteLine("Introduce 10 números para calcular el mínimo:");
                    for (int i = 0; i < numbers1.Length; i++)
                    {
                        numbers1[i] = int.Parse(Console.ReadLine());
                        if (numbers1[i] < min)
                        {
                            min = numbers1[i];
                        }
                    }
                    Console.WriteLine("El mínimo es: " + min);
                    break;
                case "3":
                    int[] numbers2 = new int[10]; // Declaramos un array de 10 elementos
                    Console.WriteLine("Introduce 10 números para calcular la mediana:");
                    for (int i = 0; i < numbers2.Length; i++)
                    {
                        numbers2[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(numbers2); // Ordenamos el array de números
                    double median;
                    if (numbers2.Length % 2 == 0)
                    { // Si el número de elementos es par
                        median = (numbers2[numbers2.Length / 2 - 1] + numbers2[numbers2.Length / 2]) / 2.0;
                    }
                    else
                    { // Si el número de elementos es impar
                        median = numbers2[numbers2.Length / 2];
                    }
                    Console.WriteLine("La mediana es: " + median);
                    break;
                case "4":
                    int[] numbers3 = new int[5];
                    int sum = 0;
                    double avg;

                    Console.WriteLine("Introduce 5 números:");

                    for (int i = 0; i < 5; i++)
                    {
                        numbers3[i] = Convert.ToInt32(Console.ReadLine());
                        sum += numbers3[i];
                    }

                    avg = (double)sum / 5;

                    Console.WriteLine("La media es: " + avg);
                    Console.ReadKey();
                    break;
                case "5":
                    int[] numbers4 = new int[5];

                    Console.WriteLine("Enter 5 numbers:");

                    for (int i = 0; i < 5; i++)
                    {
                        numbers4[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Array.Sort(numbers4);

                    Console.WriteLine("The numbers in ascending order are:");
                    foreach (int num4 in numbers4)
                    {
                        Console.WriteLine(num4);
                    }

                    Console.ReadKey();
                    break;
                case "6":
                    double[] numbers5 = new double[10]; // Declaramos un array de 10 elementos
                    double mean, variance, stdDev;

                    Console.WriteLine("Introduce 10 números para calcular la desviación típica:");
                    for (int i = 0; i < numbers5.Length; i++)
                    {
                        numbers5[i] = double.Parse(Console.ReadLine());
                    }
                    mean = numbers5.Average(); // Calculamos la media
                    variance = numbers5.Select(x => Math.Pow(x - mean, 2)).Sum() / numbers5.Length; // Calculamos la varianza
                    stdDev = Math.Sqrt(variance); // Calculamos la desviación típica
                    Console.WriteLine("La desviación típica es: " + stdDev);
                    break;
                case "7":
                    Console.Write("Introduce un número: ");
                    int n = int.Parse(Console.ReadLine());

                    // Crear el array original
                    int[] original = { 2, 4, 6, 8, 10 };

                    // Crear el array resultado y darle el mismo tamaño que el array original
                    int[] resultado = new int[original.Length];

                    // Recorrer el array original y asignar 0 o 1 al array resultado
                    for (int i = 0; i < original.Length; i++)
                    {
                        if (original[i] < n)
                            resultado[i] = 0;
                        else
                            resultado[i] = 1;
                    }

                    // Imprimir el array resultado
                    Console.Write("Array resultado: ");
                    for (int i = 0; i < resultado.Length; i++)
                    {
                        Console.Write(resultado[i] + " ");
                    }
                    Console.ReadLine();
                    break;
                case "8":
                    Console.WriteLine("Saliendo...");
                    return;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}