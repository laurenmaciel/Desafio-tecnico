using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine().ToUpper(); // deixa tudo maiúsculo

        // Substituições
        frase = frase.Replace("A", "@");
        frase = frase.Replace("E", "#");
        frase = frase.Replace("I", "!");
        frase = frase.Replace("O", "$");
        frase = frase.Replace("U", "%");

        Console.WriteLine("Texto cifrado: " + frase);

        Console.ReadKey();
    }
    
}
    


