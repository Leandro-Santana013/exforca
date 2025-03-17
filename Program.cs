// See https://aka.ms/new-console-template for more information
string palavra = "palmeiras";
Console.Write("Adivinhe uma letra: ");
string chute = Console.ReadLine();

Console.Write((palavra.IndexOf(chute) >= 0) ? $"A letra {chute} está presente na palavra!" : " Errou!");