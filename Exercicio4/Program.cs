Console.Write("CALCULADORA SIMPLES: \n\n");

Console.Write("Número 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Número 2: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Soma: {a + b}");
Console.WriteLine($"Subtração: {a - b}");
Console.WriteLine($"Multiplicação: {a * b}");
Console.WriteLine($"Divisão inteira: {a / b}");
