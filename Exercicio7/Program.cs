// Leitura segura de numero

try 
{
    Console.Write("Digite um número inteiro: ");
    int.Parse(Console.ReadLine());
} 
catch 
{
    Console.WriteLine("Entrada inválida. Digite apenas números.");
}
