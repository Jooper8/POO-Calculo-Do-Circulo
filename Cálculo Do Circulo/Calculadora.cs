//Frederico Guilherme Camilli Proença RA:200925
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_Do_Circulo
{
    //Classe na qual serão realizados os cálculos solicitados pelo programa principal.
    class Calculadora
    {
        //Instanciação da variável Pi, que neste caso sempre será 3.14.
        public double Pi = 3.14;

        //Instanciação da variável Circunferencia.
        public double Circunferencia(double r)
        {
            //Fórmula para calcular o resultado da variável Circunferencia.
            return 2.0 * Pi * r;
        }

        //Instanciação da variável Volume.
        public double Volume(double r)
        {
            //Fórmula para calcular o resultado da variável Volume.
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
