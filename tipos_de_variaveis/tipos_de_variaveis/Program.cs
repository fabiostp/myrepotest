using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            //var a = "String";
            var b = 999.00;
            var c = 1;
            string d = "Fábio Teles";
            var e = 1.5;
            long  f = 922337203685477507; //máximo de armazenamento
            int g = 2147483647; //máximo de armazenamento
            float ff = 1.5f;

                       
            //Console.WriteLine("Conteúdo da variável 01 = " + a);
            Console.WriteLine("Conteúdo da variável 02 = " + b);
            Console.WriteLine("Conteúdo da variável 03 = " + c);
            Console.WriteLine("Conteúdo da variável 04 = " + d);
            Console.WriteLine("Conteúdo da variável 05 = " + e);
            Console.WriteLine("Conteúdo da variável 05 = " + f);
            Console.WriteLine("Conteúdo da variável 06 = " + g);
            Console.WriteLine("Conteúdo da variável 07 = " + ff);

            Animal a = new Animal();
            Leao l = new Leao();

            l = (Leao) a;
            a = l;

            Convert.ToChar(d);
            Convert.ToString(f);


        }

    }


    public class Animal
        {

        }
       

    public class Leao : Animal
        {

        }
   
}
