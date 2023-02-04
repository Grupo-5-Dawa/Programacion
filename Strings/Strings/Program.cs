internal class Program
{
    private static void Main(string[] args)
    {
        int Numero = 0;
        Console.WriteLine("\t--------------------------------------------------------------------");
        Console.WriteLine("\t Elije una opcion");
        Console.WriteLine();
        Console.WriteLine("\t 1. Redondear el número al alza");
        Console.WriteLine();
        Console.WriteLine("\t 2. Eliminar los decimales del número");
        Console.WriteLine();
        Console.WriteLine("\t 3. Dados tres coeficientes ejecutar la ecuación de segundo grado");
        Console.WriteLine();
        Console.WriteLine("\t 4. Salir");
        Console.WriteLine();
        Console.WriteLine("\t--------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("\rIntroduce un numero");

        Numero = Convert.ToInt32(Console.ReadLine());

        while (Numero >= 0 && Numero >= 5)
        {
            Console.WriteLine("No has introducido un numero o el numero debe ser mayor de 0 o menor a 5 ");
            Numero = Convert.ToInt32(Console.ReadLine());
        }

        if (Numero == 1)
        {
            Console.Clear();
            Console.WriteLine("\t Haz elegido redondear el número al alza");
            Console.WriteLine();
            Console.WriteLine("Introduce un numero decimal");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double decimalNumber))
            {
                double roundedNumber = Math.Ceiling(decimalNumber);
                Console.WriteLine("Numero redondeado al alza: " + roundedNumber);
            }
            else
            {
                Console.WriteLine("Numero Invalido Introduce un nuermo decimal.");
            }

        }
        else
        {
            if (Numero == 2)
            {

                Console.Clear();
                Console.WriteLine("\t Haz elegido eliminar los decimales del número");
                Console.WriteLine();
                Console.WriteLine("Introduce un numero decimal");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double decimalNumber))
                {
                    int integerNumber = (int)decimalNumber;
                    Console.WriteLine("Numero sin decimales " + integerNumber);
                }
                else
                {
                    Console.WriteLine("Numero Invalido Introduce un nuermo decimal.");
                }
            }
            else 
            {
                if (Numero == 3)
                {
                    Console.Clear(); 
                    Console.WriteLine("\t Haz elegido dados tres coeficientes ejecutar la ecuación de segundo grado");
                    Console.WriteLine();
                    Console.WriteLine("Por favor Introduzca el Priemer Coeficiente de la ecuacion de 2 grado:");
                    string Primero = Console.ReadLine();

                    Console.WriteLine("Por favor Introduzca el Segundo Coeficiente de la ecuacion de 2 grado:");
                    string Segundo = Console.ReadLine();

                    Console.WriteLine("Por favor Introduzca el Tercer Coeficiente de la ecuacion de 2 grado:");
                    string Tercero = Console.ReadLine();

                    if (double.TryParse(Primero, out double a) &&
                        double.TryParse(Segundo, out double b) &&
                        double.TryParse(Tercero, out double c))
                    {
                        double Formula = b * b - 4 * a * c;
                        if (Formula >= 0)
                        {
                            double sqrtDiscriminant = Math.Sqrt(Formula);
                            double x1 = (-b + Formula) / (2 * a);
                            double x2 = (-b - Formula) / (2 * a);
                            Console.WriteLine("La solucion es = " + x1 + " Y tambien = " + x2);
                        }
                        else
                        {
                            Console.WriteLine("La ecuacion no tiene solucion real.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Introduzca Numeros");
                    }


                }
                else

                {
                    if (Numero == 4) 

                    {
                        Console.Clear();

                        Console.WriteLine("Haz Elegido Salir pulsa Cualquier tecla para salir");
                    }
                    else 
                    {
                        Console.WriteLine("Pulsa Cualquier tecla para salir ");
                    
                    }
                
                }

            }

        
        
        }
    }
}