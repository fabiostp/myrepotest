using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneSeUmProgramador
{
    class Program
    {
        static void Main(string[] args)
        {


            var a = 1;
            if (1 == 2)
            {
                Console.WriteLine("Condição if");
            }
            
            else if (a == 2)
            {
                Console.WriteLine("Senão outra condição if");

            }
            else
            {
                Console.WriteLine("Se não cai no senão");
            }
                
            Console.WriteLine("Pensando...");
           

            int caseSwitch = 1;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                case 3:
                    Console.WriteLine("Caso 3");
                    break;
            }

            var b = 1;
            string teste = "Teste";
           if(b == 1)
            {
                teste = "o valor de ";

            }
            else
            {
                teste = "mais um";

            }
           

            teste = (b == 1 ? "b é igual a 1" : "b não é igual a 1");
            Console.WriteLine("olá pessoal " + teste);


            var contaIdade = 27 + 1;
            
            Console.WriteLine("Olá, eu tenho " + contaIdade + " anos de idade!");

            var operadorLogico = 2;
            if (operadorLogico == 2 && operadorLogico == 2)
            {
                Console.WriteLine("Deu certo");
            }


            int Logico = 3;
            if((Logico == 3 || Logico == 3) || 1 == 1)
            {
                Console.WriteLine("Deu certo também");
            }

            Console.Read();

            // && || > < == !=

            //while ()
            //do while 
            //for foreach
            //funções recursivas
    

        

        }
    }
}
