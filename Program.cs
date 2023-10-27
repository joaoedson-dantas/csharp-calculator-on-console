namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        Soma();
    }

    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite um segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        Console.WriteLine("");
        Console.WriteLine($"O resultado da soma é: {resultado}");
    }
}
