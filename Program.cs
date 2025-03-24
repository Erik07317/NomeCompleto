Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!;
Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");
Console.Write($"Seu nome catálogo é: {sobrenome.ToUpper()}, {nome}");

