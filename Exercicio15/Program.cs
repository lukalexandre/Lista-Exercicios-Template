// Desafio - Simulador de compra

try 
{
    Console.Write("Produto: ");
    string prod = Console.ReadLine();
    Console.Write("Preço Unitário: ");
    decimal vUnit = decimal.Parse(Console.ReadLine());
    Console.Write("Quantidade: ");
    int qtd = int.Parse(Console.ReadLine());

    decimal total = vUnit * qtd;

    Console.WriteLine("\nResumo da compra:");
    Console.WriteLine("Produto: " + prod);
    Console.WriteLine("Quantidade: " + qtd);
    Console.WriteLine("Total: R$ " + total);
} 
catch 
{
    Console.WriteLine("Erro nos dados de preço ou quantidade.");
}
