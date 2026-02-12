// Minicalculadora com metodo

Console.Write("Valor A: ");
int valA = int.Parse(Console.ReadLine());
Console.Write("Valor B: ");
int valB = int.Parse(Console.ReadLine());
Console.WriteLine("Soma: " + Somar(valA, valB));

int Somar(int a, int b) => a + b;
