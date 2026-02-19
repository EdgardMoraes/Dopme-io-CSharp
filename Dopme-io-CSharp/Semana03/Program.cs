// See https://aka.ms/new-console-template for more information

using Semana03;

Console.WriteLine(ConversorTemperatura.CelsiusParaFahrenheit(34));
Console.WriteLine(ConversorTemperatura.FahrenheitParaCelsius(97));
Console.WriteLine(ConversorTemperatura.CelsiusParaKelvin(39));
double temp = 35.6;
string tipo = "F";
Console.WriteLine(ConversorTemperatura.ExibirTemperatura(temp,tipo));
Console.WriteLine(ConversorTemperatura.Validar(32,"f"));
Console.WriteLine(ConversorTemperatura.CalcularMedia(10,5,3,4));
Console.WriteLine(ConversorTemperatura.SomarTemperaturas());