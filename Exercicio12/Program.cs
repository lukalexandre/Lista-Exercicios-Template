Console.Write("ÁREA DO RETÂNGULO: \n\n");

Console.Write("Base: ");
double bse = double.Parse(Console.ReadLine());
Console.Write("Altura: ");
double alt = double.Parse(Console.ReadLine());
Console.WriteLine($"Área: {bse * alt}");
Console.WriteLine($"Perímetro: {2 * (bse + alt)}");
