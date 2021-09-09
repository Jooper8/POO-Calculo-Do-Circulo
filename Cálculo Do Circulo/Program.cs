//Frederico Guilherme Camilli Proença RA:200925
using System;
using System.Globalization;

namespace Cálculo_Do_Circulo
{
    //Programa principal com o qual o usuário interagirá.
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciado a calculadora "calc" que utilizará as variáveis da classe "Calculadora".
            Calculadora calc = new Calculadora();

            //Instanciando as variáveis raio, circ e volume.
            double raio, circ, volume;

            //Pedido do valor do raio ao usuário.
            Console.WriteLine("Insira o valor do raio:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo da circunferência e do volume, utilizando variáveis já instanciadas e as fórmulas Circunferencia e Volume já introduzidas na classe Calculadora.
            circ = calc.Circunferencia(raio);
            volume = calc.Volume(raio);

            //Anunciando os resultados ao usuário, convertendo os resultados à string.
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
