using System;
using System.Collections.Generic;
using System.Text;

namespace Scripts
{
    class yieldTest
    {
        public static void Exec()
        {
            IEnumerable<int> tesste = funcaoIE(10);
            foreach (var item in tesste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            List<int> lista = funcaoList(10);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            IEnumerable<int> tessste = funcaoIEt(10);
            foreach (var item in tessste)
            {
                Console.WriteLine(item);
            }
        }
        static IEnumerable<int> funcaoIE(int valor)
        {
            for (int i = 1; i <= valor; i++)
            {
                yield return i;
                if (i == 5)
                {
                    yield break;
                }
            }            
        }        
        static List<int> funcaoList(int valor)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < valor; i++)
            {
                lista.Add(i);
            }                       
            return lista;
        }
        static IEnumerable<int> funcaoIEt(int valor)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < valor; i++)
            {
                lista.Add(i);
            }
            return lista;
        }
    }
}