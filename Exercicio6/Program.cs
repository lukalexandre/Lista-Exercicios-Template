Console.Write("CONVERSOR DE TEMPERATURA: \n\n");
Console.Write("Graus Celsius: ");
double c = double.Parse(Console.ReadLine());
double f = (c * 9 / 5) + 32;
Console.WriteLine($"Fahrenheit: {f}");
