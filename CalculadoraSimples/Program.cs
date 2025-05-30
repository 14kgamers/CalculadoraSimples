using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora Simples em C#");
        Console.WriteLine("Escolha a operação (+, -, *, /): ");
        char operacao = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Digite o primeiro Número:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo Número:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;
        bool operacaoValida = true;

        switch (operacao)
        {
            case '+':
                resultado = n1 + n2;
                break;

            case '-':
                resultado = n1 - n2;
                break;

            case '*':
                resultado = n1 * n2;
                break;

            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero!");
                    operacaoValida = false;
                }
                else
                {
                    resultado = n1 / n2;
                }
                break;

            default:
                Console.WriteLine("Operação invalida!");
                operacaoValida = false;
                break;
        }

        if (operacaoValida)
        {
            Console.WriteLine($"Resultado: {resultado}");
        }
        Console.WriteLine("Pressione qualuqer tecla para sair...");
        Console.ReadKey();
    }
}