// See https://aka.ms/new-console-template for more information


Console.WriteLine("Calculadora Simples");
Console.WriteLine("Operações dispoíveis: +, -, *, / \n");

bool continuar = true;

while (continuar)
{
    Console.Write("Digite o primeiro número: ");
    string? input1 = Console.ReadLine();

    if (!double.TryParse(input1, out double numero1))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        continue;
    }

    Console.Write("Digite o segundo número: ");
    string? input2 = Console.ReadLine();

    if (!double.TryParse(input2, out double numero2))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        continue;
    }

    Console.Write("Digite a operação (+, -, *, /): ");
    string? operacao = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(operacao))
    {
        Console.WriteLine("Operação inválida. Por favor, tente novamente.");
        continue;
    }

    double resultado = 0;
    bool operacaoValida = true;
    string mensagemErro = "";


    switch (operacao)
    {
        case "+":
            resultado = numero1 + numero2;
            break;
        case "-":
            resultado = numero1 - numero2;
            break;
        case "*":
            resultado = numero1 * numero2;
            break;
        case "/":
            if (numero2 == 0)
            {
                operacaoValida = false;
                mensagemErro = "Erro: Divisão por zero não é permitida.";
            }
            else
            {
                resultado = numero1 / numero2;
            }

            break;
        default:
            operacaoValida = false;
            mensagemErro = "Operação inválida. Por favor, tente novamente.";
            break;
    }

    if (operacaoValida)
    {
        string resultadoFormatado = resultado.ToString("F2");

        if (resultado == Math.Floor(resultado))
        {
            resultadoFormatado = resultado.ToString("F0");
        }

        Console.WriteLine($"Resultado:{numero1} {operacao} {numero2} = {resultadoFormatado}\n");
    }
    else
    {
        Console.WriteLine($"{mensagemErro}\n");
    }

    Console.Write("Deseja realizar outra operação? (s/n): ");
    string? resposta = Console.ReadLine()?.Trim().ToLower();

    if (resposta != "s" && resposta != "sim" && resposta != "y" && resposta != "yes")
    {
        continuar = false;
    }

    Console.WriteLine("Obrigado por usar Calculadora Simples!");
}