using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace comprassupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosTeste = Convert.ToInt16(Console.ReadLine());
            ///Casos de teste devem estar entre 1 e 100
            if (casosTeste < 1 || casosTeste > 100) { return; }

            string[] itens = new string[casosTeste];
            string[] itensFinais = new string[casosTeste];

            for (int i = 0; i < casosTeste; i++)
            {
                itens[i] = Console.ReadLine();
            }
            for (int i = 0; i < casosTeste; i++)
            {
                itens[i] = removerAcentos(itens[i]);
                List<String> listaFinal = itens[i].Split().Distinct().ToList();
                listaFinal.Sort();
                string resultado = "";
                foreach (string valor in listaFinal)
                {
                    resultado += valor + ' ';
                }
                Console.WriteLine(resultado.Substring(0, resultado.Length - 1));

            }

            Console.ReadLine();
        }

        public static string removerAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }
    }
}
