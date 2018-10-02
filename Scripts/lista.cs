using System;
using System.Collections.Generic;
using System.Text;

namespace Scripts
{
    class lista
    {
        public static void Exec()
        {
            
            Exemplo3();

        }

        private static void Exemplo1()
        {
            List<string> teste = new List<string> { "1", "2", "3" };
            foreach (var item in teste)
            {
                Console.WriteLine(item);
            }
        }
        private static void Exemplo2()
        {
            string[] teste = new string[] { "1", "2", "3" };
            foreach (var item in teste)
            {
                Console.WriteLine(item);
            }

        }
        private static void Exemplo3()
        {
            IEnumerable<string> teste = new string[] { "1", "2", "3" };
             
            foreach (var item in teste)
            {
                Console.WriteLine(item);
            }


        }
    }
}
