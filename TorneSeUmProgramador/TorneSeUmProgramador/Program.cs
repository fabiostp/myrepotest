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
            var aa = 1;
            if (1 == 2)
            {
                Console.WriteLine("Não cai nessa condição");
            }
            
            else if (aa == 2)
            {
                Console.WriteLine("Também não cai nessa condição");

            }
            else
            {
                Console.WriteLine("Se não cair nas condições anteriores então a mensagem é essa!");
            }
                
            Console.WriteLine("Pensando...");
           

            int caseSwitch = 1;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Caso 1 a mensagem é essa");
                    break;
                case 2:
                    Console.WriteLine("Caso 2 a mensagem é essa");
                    break;
                case 3:
                    Console.WriteLine("Caso 3 a mensagem é essa");
                    break;
            }

            var b = 1;
            string teste = "valor inicial";
           if(b == 1)
            {
                teste = "valor de teste se b igual a 1";
            }
            else
            {
                teste = "valor de teste se b não for igual a 1";

            }
           

            teste = (b == 1 ? "valor de teste é 1" : "valor de teste não é 1");
            Console.WriteLine("Olá Fábio o " + teste);


            var contaIdade = 27 + 1;
            
            Console.WriteLine("Eu tenho " + contaIdade + " anos de idade!");

            var minhaVariavel = 2;
            if (minhaVariavel == 2 && minhaVariavel > 1)
            {
                Console.WriteLine("Deu certo, a minha variável é igual a 2 e 2 é maior que 1");
            }


            int minhaVariavel2 = 3;
            if((minhaVariavel2 == 3 || minhaVariavel2 < 5) || 1 == 1)
            {
                Console.WriteLine("Deu certo também, minha variável 2 é igual a 3 e 3 é menor que 5");
            }

           

            //&&    AND 
            //||    OR
            //>     MAIOR
            //<     MENOR
            //==    IGUAL
            //!=    DIFERENTE

            //while ()    ENQUANTO
            //do while     FAÇA ENQUANTO
            //for foreach   PARA CADA
            //funções recursivas


            var contador = 1;

            while (contador <= 999)
            {
                Console.WriteLine("Teste do primeiro looping com conteúdo = " + contador);
                contador = contador + 1;
            }
            
            contador = 1;


            do 
            {
                Console.WriteLine("Teste do segundo looping com conteúdo = " + contador);
                contador ++;
             
            } while (contador <= 10);


          

            for(int cont = 1 ; cont <= 10; cont++)
            {
                Console.WriteLine("Teste do terceiro looping com conteúdo = " + cont);
            }            
        
                                 
            Console.Read();

            //looping(1);          

        }
        /*
        public void looping(int c) 
        {
              Console.WriteLine(c);
              if(c = 10) 
              {
                  looping(c + 1);                 
              }
               
        }   
        */

        
       
    }
}
