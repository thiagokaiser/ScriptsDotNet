using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Scripts
{
    class PropClasses
    {
        public static void Exec()
        {
            Exemplo01();
            //Exemplo02();

        }
        public static void Exemplo02()
        {
            Usuario user = new Usuario { codigo = 123, nome= "teste", bla = "asd" };
            


        }
        public static void Exemplo01()
        {
            Usuario user = new Usuario { codigo = 123, bla = "asd" };
            Console.WriteLine(user.codigo);

            List<object> teste = new List<object> { };
            PropertyInfo[] propriedades = typeof(Usuario).GetProperties();
            foreach (var item in propriedades)
            {
                object valor = item.GetValue(user, null);
                if (valor != null)
                {
                    teste.Add(valor);
                }
            }


            foreach (var item in teste)
            {
                Console.WriteLine(item);

            }
        }

    }

    class Usuario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string bla { get; set; }

    }
}
