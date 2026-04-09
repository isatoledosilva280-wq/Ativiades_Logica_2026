using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

    //Integrantes:
    //Miguel, Izabella, Ana, Indrid e João.


class Program
{
    
    static void Main()
    {
        //Determinação da variável int (contagem de erros). Começa do 0, para ser determinada ao decorrer do código.
        int erro = 0;
        //Letras e bool.
        bool f = false;
        bool l = false;
        bool o = false;
        bool a = false;
        bool t = false;

        //Emoji.
        Console.OutputEncoding = Encoding.UTF8;
        //História.
        Console.WriteLine("A muito tempo foi criado o famoso jogo da forca. 🤐\n" +
            "Quem hoje acredita que seja uma simples brincadeira, mal sabe \n" +
            "que foi feita para decidir a vida ou a morte 💀☠️. A muitos anos, \n" +
            "uma punição se espalhou, onde ladrões, \n" +
            "condenados, tinham uma punição semanal entre os detentos. \n" +
            "Essa, no qual eles teriam que adivinhar a palavra que os guardas disserem, apenas dando \n" +
            "o números de letras 🔤, \n" +
            "porém com poucas chances. Se o presidiário errasse três vezes 🥉, \n" +
            "este seria assassinado na forca na frente de todos, sem nenhuma dignidade. \n" +
            "Já se ele acertasse, estaria vivo por mais uma semana, talvez...");
        Console.WriteLine("Olá condenado! O tema de hoje, será: C#!");
        Console.WriteLine("Funcionará deste modo, escreva uma letra, de acordo com os espaços vazios, se você acertar a palavra\n" +
          "você não se churrascará 🍖☠️💀⚰️, caso erre 3 vezes, perde. \n\nNúmero de letras:" +
         //Palavras com 5 letras.
          "\n\n_____");

        //Se o número de erros foi igual a 3, o jogador perde. Se for menor, ele apenas retorna ao código.
    tentativa1:
        if (erro >= 3) { Mostrar(f, l, o, a, t, erro); return; }

        //Letras escolhidas.
        Console.WriteLine("\nDigite alguma letra:");
        string palavras = Console.ReadLine();

        if (palavras == "f") f = true;
        else if (palavras == "l") l = true;
        else if (palavras == "o") o = true;
        else if (palavras == "a") a = true;
        else if (palavras == "t") t = true;
        else { erro++; Console.WriteLine("\nVocê errou!❌"); }

        //Utilizando o static void
        Mostrar(f, l, o, a, t, erro);

        //Se caso acertar
        if (f && l && o && a && t) return;

        goto tentativa1;

        //Static void é como se você tivesse uma “mini função” pronta, que você só precisa chamar e passar os parâmetros certos.
        //Você pode usar ela acima da onde você à definiu.
        //As funções abaixo, são apenas para escrever no console a letra escolhida, se não escolhida "_" é escrito.
        static void Mostrar(bool f, bool l, bool o, bool a, bool t, int erro)
        {
            if (f)
                Console.Write("f");
            else
                Console.Write("_");

            if (l)
                Console.Write("l");
            else
                Console.Write("_");

            if (o)
                Console.Write("o");
            else
                Console.Write("_");

            if (a)
                Console.Write("a");
            else
                Console.Write("_");

            if (t)
                Console.Write("t");
            else
                Console.Write("_");

            //Se as letras abaixo ocorrerem, a mensagem "Você ganhou!✓" aparece.
            if (f && l && o && a && t)
                Console.WriteLine("\nVocê ganhou!✓");

            //Caso o erro seja de 3, fim de jogo.
            if (erro >= 3)
                Console.WriteLine("\nVocê perdeu!❌");
        }
    }
}
