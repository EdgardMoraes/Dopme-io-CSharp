namespace Semana03;

public class ConversorTemperatura
{
    public static double CelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitParaCelsius(double fahrenheit)
        {
            // double celsius = (fahrenheit - 32) * 5 / 9;
            // return Math.Round(celsius * 100.0) / 100.0;
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusParaKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public static void ExibirTemperatura(double celsius)
        {
            Console.WriteLine($"Temperatura {celsius}ºC");
        }

        public static bool ExibirTemperatura(double celsius, string escala)
        {
            if (escala == "F")
            {
                // var retorno = (celsius * 9 / 5) + 32;
                double farenheit = CelsiusParaFahrenheit(celsius);
                Console.WriteLine($"Temperatura {Math.Round(farenheit, 2)}º{escala}");
                
            }
            else if (escala == "K")
            {
                // var retorno = celsius + 273.15;
                double kelvin = CelsiusParaKelvin(celsius);
                Console.WriteLine($"Temperatura {Math.Round(kelvin, 2)}º{escala}");
            }
            else
            {
                Console.WriteLine($"Temperatura {Math.Round(celsius, 2)}º{escala}");
            }
            return true;
        }

        public static bool Validar(double temperatura)
        {
            return temperatura < -273.15 ? false : true;
        }

        public static bool Validar(double temperatura, string escala)
        {
            if (escala == "f")
            {
                return temperatura >= -479.67 ? true : false;
            }
            else if (escala == "k")
            {
                return temperatura >= 0 ? true : false;
            }
            else
            {
                return temperatura >= 273.15 ? true : false;
            }
        }

        public static double CalcularMedia(double temp1, double temp2, double temp3 = 0, double temp4 = 0,
            double temp5 = 0)
        {
            // return (temp1 + temp2 + temp3 + temp4 + temp5) / 5;
            double soma = temp1 + temp2;
            int qtd = 2;
            if (temp3 != 0)
            {
                soma += temp3;
                qtd++;
            }

            if (temp4 != 0)
            {
                soma += temp4;
                qtd++;
            }

            if (temp5 != 0)
            {
                soma += temp5;
                qtd++;
            }

            return Math.Round(soma / qtd, 2);
        }

        public static double SomarTemperaturas(params double[] temperaturas)
        {
            // double soma = 0;
            //
            // foreach (double temp in temperaturas)
            // {
            //     soma += temp;
            // }
            //
            // return soma;

            if (temperaturas.Length == 0)
            {
                Console.WriteLine("nenhuma temperatura foi informada.");
                return 0;
            }

            double soma = 0;
            foreach (double temp in temperaturas)
            {
                soma += temp;
            }

            return soma;
        }
}