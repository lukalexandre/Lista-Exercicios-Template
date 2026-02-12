// Salario mensal

Console.Write("Valor por hora: ");
decimal valorHora = decimal.Parse(Console.ReadLine());
Console.Write("Horas trabalhadas: ");
decimal horasMes = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Salário final: R$ {valorHora * horasMes}");
