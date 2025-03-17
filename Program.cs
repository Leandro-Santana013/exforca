// See https://aka.ms/new-console-template for more information
String palavra = "", chute = "",
Console.write("digite a palavra secreta");
palavra = Console.ReadLine;

Console.Write("Adivinhe uma letra: ");
chute = Console.ReadLine();

Console.Write((palavra.IndexOf(chute) >= 0) ? $"A letra {chute} está presente na palavra!" : " Errou!");
