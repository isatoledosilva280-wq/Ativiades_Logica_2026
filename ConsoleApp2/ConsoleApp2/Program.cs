```csharp
using System;

class Program
{
    static void Main(
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Classe: ");
        string classe = Console.ReadLine();

        Console.Write("Nível: ");
        int nivel = int.Parse(Console.ReadLine());

        Console.Write("HP: ");
        double hp = double.Parse(Console.ReadLine());

        Console.Write("Mana: ");
        int mana = int.Parse(Console.ReadLine());

        Console.Write("Ouro: ");
        double ouro = double.Parse(Console.ReadLine());

        if (classe == "Troll")
        {
            Console.WriteLine("Troll expulso da guilda!");
            return;
        }
        else if (nivel < 5)
        {
            Console.WriteLine("Nível muito baixo.");
            return;
        }

        double poderBase = (nivel * 10) + (hp / 2) - 5;
        Console.WriteLine("Poder Base: " + poderBase);

        if (poderBase % 2 == 0)
        {
            Console.WriteLine("Ataque Crítico!");
        }

        bool podeAtacar = false;

        if (classe == "Mago" || classe == "Druida" || classe == "Clérigo")
        {
            if (mana >= 30 && nivel <= 100)
            {
                Console.WriteLine("Ataque mágico!");
                podeAtacar = true;
            }
        }
        else if (classe == "Guerreiro" || classe == "Anão" || classe == "Elfo")
        {
            if (hp > 20 && poderBase > 50)
            {
                Console.WriteLine("Ataque físico!");
                podeAtacar = true;
            }
        }

        if (!podeAtacar)
        {
            if (ouro > 1000 || classe == "Anão")
            {
                Console.WriteLine("Suborno aceito pelo dragão!");
            }
            else
            {
                Console.WriteLine("Virou churrasco de dragão!");
            }
        }
    }
}
```
