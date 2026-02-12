// Media de 2 provas

Console.Write("Nota 1: ");
double nt1 = double.Parse(Console.ReadLine());
Console.Write("Nota 2: ");
double nt2 = double.Parse(Console.ReadLine());
double media = (nt1 + nt2) / 2;
Console.WriteLine("Média: " + media.ToString("F2"));
