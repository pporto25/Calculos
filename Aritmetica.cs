using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementar operações aritméticas
    ///</summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        ///     Operação Soma que recebe dois números inteiros e retorna a soma dos mesmos
        /// </summary>
        /// returns>Retorna a soma dos dois números inteiros</returns>

        public static  int Somar(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        ///     Operação Subtração que recebe dois números inteiros e retorna a soma dos mesmos
        /// </summary>
        /// /// returns>Retorna a subtração  dos dois números inteiros</returns>
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }
    }
}
