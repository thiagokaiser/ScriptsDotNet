using System;
using System.Collections.Generic;
using System.Text;

namespace Scripts
{
    class teste
    {
        int i;

        public static void Exec()
        {
            teste variavel = new teste { i = 22 };
            Console.WriteLine("teste" + variavel.i);
        }
    }
}