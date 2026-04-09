using System;

class Program
{
    static void Main()
    {
        float n = 0, soma = 0;
        int cont = 0;

        while (true)
        {
            Console.Write("Digite o número: ");
            float.TryParse(Console.ReadLine().Replace(".", ","), out n);

            soma += n;
            cont++;

            Console.Write("Quer sair do programa [S/N]: ");
            string sair = Console.ReadLine().ToLower();

            if (sair == "s")
            {
                break;
            }
        }

        if (cont > 0)
        {
            float media = soma / cont;
            Console.WriteLine($"Média: {media}");
        }
    }
}