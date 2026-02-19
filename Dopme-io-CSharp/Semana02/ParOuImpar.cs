namespace Semana02;

public class ParOuImpar
{
    public static void VerificarParOuImpar()
    {
        Console.Write("Digite um número inteiro: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
        }
    }

    public void ImprimirParOuImpar()
    {
        Console.Write("Digite um número inteiro: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
        }
    }
}