// Troco

Console.Write("Valor do produto: ");
decimal preco = decimal.Parse(Console.ReadLine());
Console.Write("Valor pago: ");
decimal pago = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Troco: R$ {pago - preco}");
