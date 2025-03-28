// See https://aka.ms/new-console-template for more information
String palavra = "", chute = "",
Console.write("digite a palavra secreta");
palavra = Console.ReadLine;

Console.Write("Adivinhe uma letra: ");
chute = Console.ReadLine().ToLower()  ;

Console.WriteLine($"A letra {chute} existe na palavra secreta?  => {palavra.Contains(letra)}");
