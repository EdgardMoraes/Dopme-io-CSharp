// See https://aka.ms/new-console-template for more information

 //Crie um programa que a idade de uma pessoa 

            //Console.Write("Digite sua idade: ");
            //int idade = int.Parse(Console.ReadLine());
            //string classificacao;
            //if (idade >= 0 && idade <= 12)
            //{
            //   classificacao = "criança";
            //}
            //else if (idade >= 13 && idade <= 17)
            //{
            //    classificacao = "Adolescente";
            //}
            //else if (idade >= 18 && idade <= 59) {
            //    classificacao = "Adulto";
            //}
            //else {
            //    classificacao = "Idoso";

            //}

            //Console.WriteLine($"Você é um(a) {classificacao}!");

            // Crie um programa que calcula a média e determina o conceito.

            //Console.Write("Digite a primeira nota: ");
            //double nota1 = double.Parse(Console.ReadLine());
            //Console.Write("Digite a segunda nota: ");
            //double nota2 = double.Parse(Console.ReadLine());
            //Console.Write("Digite a terceira nota: ");
            //double nota3 = double.Parse(Console.ReadLine());

            //double media = (nota1 + nota2 + nota3) / 3;
            //string conceito;
            //string status = media >= 7.0 ? "Aprovado" : "Reprovado";

            //if (media >= 9.0)
            //{
            //    conceito = "A";

            //}
            //else if (media >= 7.0)
            //{
            //    conceito = "B";

            //}
            //else if (media >= 5.0)
            //{
            //    conceito = "C";

            //}
            //else
            //{
            //    conceito = "D";

            //}
            //Console.WriteLine($"A média é: {media}, Conceito {conceito} e o status é: {status}");


            //use switch case para converter um numero em dia da semana

            //Console.Write("Digite um numero (1-7)");
            //int dia = int.Parse((Console.ReadLine()));
            //string nomeDia;

            //switch (dia)
            //{

            //    case 1:
            //        nomeDia = "Domingo";
            //        break;
            //    case 2:
            //        nomeDia = "Segunda-feira";
            //        break;
            //    case 3:
            //        nomeDia = "Terça-feira";
            //        break;
            //    case 4:
            //        nomeDia = "Quarta-feira";
            //        break;
            //    case 5:
            //        nomeDia = "Quinta-feira";
            //        break;
            //    case 6:
            //        nomeDia = "Sexta-feira";
            //        break;
            //    case 7:
            //        nomeDia = "Sábado";
            //        break;
            //    default:
            //        nomeDia = "Número inválido";
            //        break;

            //}

            //Console.WriteLine($"O dia da semana é: {nomeDia}");

            //// Crie um programa de login simples

            //string usuarioCorreto = "admin";
            //string senhaCorreta = "senha123";

            //Console.Write("Digite o Usuário: ");
            //string usuario = Console.ReadLine();

            //Console.Write("Digite a senha: ");
            //string senha = Console.ReadLine();
            //string statusLogin = usuario == usuarioCorreto && senha == senhaCorreta ? "Acesso concedido" : "Acesso Negado";

            //Console.WriteLine($"{statusLogin}");

          


            ////Simule a aprovação de um empréstimo bancário

            //Console.Write("Digite sua idade: ");
            //int idadeEmprestimo = int.Parse(Console.ReadLine());

            //Console.Write("Digite sua renda mensal: ");
            //double rendaMensal = double.Parse(Console.ReadLine());

            //Console.Write("Possui dívida? (sim/não)");
            //string temDivida = Console.ReadLine().ToLower();
            ////string statusEmprestimo;
            ////string motivoRecusa = "";
            //bool idadeValida = idadeEmprestimo >= 18 && idadeEmprestimo <= 70;
            //bool rendaValida = rendaMensal >= 2000;
            //bool dividaValida = temDivida == "não";


            //if (idadeValida && rendaValida && dividaValida)
            //{

            //    Console.WriteLine("Emprestimo Aprovado!");

            //}
            //else 
            //{

            //    Console.WriteLine($"Emprestimo Reprovado! Motivo: ");
            //    if (!idadeValida)
            //    {
            //        Console.WriteLine("- Idade inválida. Deve estar entre 18 e 70 anos.");
            //    }
            //    else if (!rendaValida)
            //    {
            //        Console.WriteLine("- Renda mensal insuficiente. Deve ser pelo menos R$2000.");
            //    }
            //    else if (!dividaValida)
            //    {
            //        Console.WriteLine("- Possui dívidas pendentes.");
            //    }
            //}

            //// Conversor de tempertura

            //Console.WriteLine("1. Celsius para Fahrenheit");
            //Console.WriteLine("2. Fahrenheit para Celsius");
            //Console.Write("Escolha uma das opções: ");

            //int opcao = int.Parse(Console.ReadLine());

            //Console.Write("Digite a Temperatura: ");
            //double temperatura = double.Parse(Console.ReadLine());
            //double resultado = 0;
            //string nomeTemperatura = "";

            //switch (opcao)
            //{
            //    case 1:
            //        resultado = (temperatura * 9 / 5) + 32;
            //        nomeTemperatura = "Fahrenheit";
            //        break;

            //    case 2:
            //        resultado = (temperatura - 32) * 5 / 9;
            //        nomeTemperatura = "Celsius";
            //        break;

            //    default:
            //        Console.WriteLine("Opção inválida");
            //        break;

            //}

            //Console.WriteLine($"{temperatura} convertido = {resultado:f2} {nomeTemperatura}");

            ////Sistema de descontos

            //Console.Write("Digite o valor da compra: ");
            //double valor = double.Parse(Console.ReadLine());

            //Console.WriteLine("\nFormas de pagamento: ");
            //Console.WriteLine("1: Á vista (10% desconto)");
            //Console.WriteLine("2. Débito (5% desconto)");
            //Console.WriteLine("3. Crédito á vista (2% desconto)");
            //Console.WriteLine("4. Crédito parcelado (sem desconto)");
            //Console.Write("Escolha a opção: ");

            //int formaPagamento = int.Parse(Console.ReadLine());
            //double desconto = 0;

            //switch (formaPagamento)
            //{
            //    case 1:
            //        desconto = 10;
            //        break;
            //    case 2:
            //        desconto = 5;
            //        break;
            //    case 3:
            //        desconto = 2;
            //        break;
            //    case 4:
            //        desconto = 0;
            //        break;
            //    default:
            //        Console.WriteLine("Opção inválida");
            //        return;
            //}

            //double valorDesconto = valor * desconto / 100;
            //double valorFinal = valor - valorDesconto;

            //Console.WriteLine($"Valor original: R$ {valor:f2} \nDesconto: R$ {valorDesconto:f2} ({desconto}%) \nValor final R$ {valorFinal:f2}");


            // Menu Interativo

            using Semana02;

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n===Menu===");
                Console.WriteLine("1. Verificar Par ou Ímpar");
                Console.WriteLine("2. Calcular média");
                Console.WriteLine("3. Calculadora");
                Console.WriteLine("4. Verificar Triangulo");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha a opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Crie um programa que verifica se um numero é par ou impar
                        //VerificarParOuImpar();
                        ParOuImpar imprimir = new ParOuImpar();
                        imprimir.ImprimirParOuImpar();
                        break;
                    case 2:
                        Console.Write("Digite a primeira nota: ");
                        double nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a segunda nota: ");
                        double nota2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a terceira nota: ");
                        double nota3 = double.Parse(Console.ReadLine());

                        double media = (nota1 + nota2 + nota3) / 3;
                        string conceito;
                        string status = media >= 7.0 ? "Aprovado" : "Reprovado";

                        if (media >= 9.0)
                        {
                            conceito = "A";

                        }
                        else if (media >= 7.0)
                        {
                            conceito = "B";

                        }
                        else if (media >= 5.0)
                        {
                            conceito = "C";

                        }
                        else
                        {
                            conceito = "D";

                        }
                        Console.WriteLine($"A média é: {media}, Conceito {conceito} e o status é: {status}");
                        break;
                    case 3:
                        Console.WriteLine("Calculadora Simples");
                        Console.WriteLine("Operações dispoíveis: +, -, *, / \n");

                        bool faca = true;

                        while (faca)
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
                        break;
                    case 4:
                        //// Crie um programa que verifica triangulos
                        Console.Write("Digite o lado A");
                        double ladoA = double.Parse(Console.ReadLine());
                        Console.Write("Digite o lado B");
                        double ladoB = double.Parse(Console.ReadLine());
                        Console.Write("Digite o lado C");
                        double ladoC = double.Parse(Console.ReadLine());

                        bool podeFormarTriangulo = (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA);

                        string tipoTriangulo;
                        if (podeFormarTriangulo)
                        {
                            if (ladoA == ladoB && ladoB == ladoC)
                            {

                                tipoTriangulo = "Equilátero";
                                //Console.WriteLine("Triângulo Equilátero");
                            }
                            else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                            {

                                tipoTriangulo = "Isósceles";
                                //Console.WriteLine("Triângulo Isósceles");
                            }
                            else
                            {

                                tipoTriangulo = "Escaleno";
                                //Console.WriteLine("Triângulo Escaleno");
                            }
                            Console.WriteLine($"Forma triângulo do tipo: {tipoTriangulo}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Programa finalizado");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opçãoinálida");
                        return;


                }

            }