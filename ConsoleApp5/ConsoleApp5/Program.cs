Console.WriteLine("=== Calculadora de IMC ===");

Console.Write("Digite seu peso (kg): ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura (m): ");
double altura = Convert.ToDouble(Console.ReadLine());

// Chamando o "comando"
CalcularIMC(peso, altura);

 Console.ReadLine();
   

    // 🔹 Método (comando) de IMC
    static void CalcularIMC(double peso, double altura)
{
    if (peso <= 0 || altura <= 0)
    {
        Console.WriteLine("Valores inválidos!");
        return;
    }

    double imc = peso / (altura * altura);

    string classificacao;

    if (imc < 18.5)
        classificacao = "Abaixo do peso";
    else if (imc < 25)
        classificacao = "Peso normal";
    else if (imc < 30)
        classificacao = "Sobrepeso";
    else if (imc < 35)
        classificacao = "Obesidade grau I";
    else if (imc < 40)
        classificacao = "Obesidade grau II";
    else
        classificacao = "Obesidade grau III";

    Console.WriteLine($"\nIMC: {imc:F2}");
    Console.WriteLine($"Classificação: {classificacao}");
}