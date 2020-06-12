using System;
using System.Collections.Generic;

namespace Prova_Recursividade
{
    class Program
    {
        private static void ImprimirInvertido(int[] array) {
            string arrayInvertido = "";
            int inverter = 0;
            List<string> arrayInvertidoFinal = new List<string>();

            for (int i = 0; i < array.Length; i++) {
                inverter = array[array.Length - 1 - i];
                arrayInvertido += inverter;
                arrayInvertidoFinal.Add(inverter + " ");
            }

            Console.WriteLine("Esse é o Array printado invertidamente: ");
            arrayInvertidoFinal.ForEach(Console.WriteLine);
            
        }

        private static void ImprimirMedia(int[] array) {
            double sum = 0;
            int maiorMedia = 0;
            List<Int32> maiorMediaFinal = new List<Int32>();

            for (int i = 0; i < array.Length; i++) {
                sum = sum + array[i];
            }
            for (int j = 0; j < array.Length; j++) {
                if (array[j] > (sum/array.Length))
                {
                    maiorMedia = array[j];
                    maiorMediaFinal.Add(maiorMedia);
                }
            }

            Console.WriteLine("Essa é a media: " + sum/array.Length);
            Console.WriteLine("E esses são os valores maiores que a media: ");
            maiorMediaFinal.ForEach(Console.WriteLine);
            
            
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 1, 3, 5, 7, 8, 32 };
            ImprimirMedia(array);
            ImprimirInvertido(array);
            
        }
    }
}
