double milha, km = 0;


Console.WriteLine("Conversor de Milhas para Km");

Console.Write("Digite uma medida em milhas: ");
milha = double.Parse(Console.ReadLine()!);

km = milha * 1.609;

Console.Write($"O valor em  quilometros é: {km}");




