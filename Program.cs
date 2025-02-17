string name;
Console.WriteLine("Meu primeiro programa");
Console.WriteLine("Qual seu nome?");

name  = Convert.ToString(Console.ReadLine());

Console.WriteLine($"Bem vinda {name}");

Console.ReadKey();