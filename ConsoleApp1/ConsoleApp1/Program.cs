```csharp
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("🌡️ Conversor de Temperatura");
        Console.Write("Digite a temperatura em Celsius (°C): ");

        if (float.TryParse(Console.ReadLine(), out float c))
        {
            float f = (c * 9 / 5) + 32;
            float k = c + 273.15f;

            Console.WriteLine($"\nResultado para {c:F2}°C:");
            Console.WriteLine($"🔥 Fahrenheit: {f:F2}°F");
            Console.WriteLine($"❄️ Kelvin: {k:F2}K");
        }
        else
        {
            Console.WriteLine("❌ Digite apenas números válidos.");
        }
    }
}
```

