// Soma segura

try 
{
    Console.Write("N1: ");
    int v1 = int.Parse(Console.ReadLine());
    Console.Write("N2: ");
    int v2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Soma: {v1 + v2}");
} 
catch 
{
    Console.WriteLine("Erro de conversão. Encerrando programa.");
}
