// Divisao segura

try 
{
    Console.Write("Dividendo: ");
    int d1 = int.Parse(Console.ReadLine());
    Console.Write("Divisor: ");
    int d2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Resultado: {d1 / d2}");
} 
catch (DivideByZeroException) 
{
    Console.WriteLine("Erro: Não é possível dividir por zero.");
} 
catch (FormatException) 
{
    Console.WriteLine("Erro: Digite apenas números válidos.");
}
