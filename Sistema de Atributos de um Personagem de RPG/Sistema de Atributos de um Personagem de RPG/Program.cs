```csharp
using System;

class Program
{
    static void Main()
    {
        // Nome do herói
        string nome = "Jennie";

        // Soma
        int ataqueBase = 10;
        int bonusArma = 5;
        int ataqueTotal = ataqueBase + bonusArma;

        // Subtração
        double vidaInimigo = 150.5;
        double vidaRestante = vidaInimigo - 50.5;

        // Multiplicação
        float moedas = 20.5f;
        var moedasFinais = moedas * 2;

        // Divisão
        long xpTotal = 1000000000;
        long mediaXp = xpTotal / 2;

        // Boolean
        bool entendiMateria = true;

        // Saída
        Console.WriteLine("Herói: " + nome);
        Console.WriteLine("Ataque Total: " + ataqueTotal);
        Console.WriteLine("Vida Restante do Inimigo: " + vidaRestante);
        Console.WriteLine("Moedas Finais: " + moedasFinais);
        Console.WriteLine("Média de XP: " + mediaXp);
        Console.WriteLine("Entendi a matéria? " + entendiMateria);
    }
}
```
