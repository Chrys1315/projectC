using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Program
    {

        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar,Listar, Atualizar }


        static void Main(string[] args)
        {

            //Int -- 156 como 32225648
            //Floar - 15.6

            /*   int segundaGuerraMundial = 1942;
               string cor_favortia = "Azul";


               Console.WriteLine(segundaGuerraMundial);
               Console.WriteLine(cor_favortia);
               Console.ReadLine();
                */

            /* const float PI = 3.1465654654f;

             Console.WriteLine("Escreva seu nome: ");
             string nome = Console.ReadLine();
             Console.WriteLine("Seu nome é: ");
             Console.WriteLine(nome);

             Console.ReadLine();
             */

            //==============================================
            /* int numeroQualquer = 20 + 20 - 80;
             int numeroMult = 10 * 90;
             int numeroDiv = 90 / 10;



             Console.WriteLine(numeroQualquer);
             Console.WriteLine(numeroMult);
             Console.WriteLine(numeroDiv);


             Console.ReadLine();
            */

            /*

              Console.WriteLine("Digite um numero [ 0 a 100 ] :");
               int num1 = int.Parse(Console.ReadLine()) ;

               if (num1 < 25)
               {
                   Console.WriteLine("Esse numero é menor que 25");
                   

               } else if (num1 > 25 && num1 < 50  )
               {
                   Console.WriteLine("Esse numero esta entre 25 e 50");
                   
               } else
               {
                   Console.WriteLine("Esse numero é maior que 50");
                  
               }

               Console.ReadLine() ;
            
            */

            /* int a = 10;
             int b = 20;
             int c = 2;

             if ( a<b)
             {
                 Console.WriteLine("É verdade");

             } else if (a > c)
             {
                 Console.WriteLine("Executou ElseIf!");
             } else
             {
                 Console.WriteLine("É mentira!");
             }

             Console.ReadLine();


             */

            // && ( E ou AND) e || (OU/OR)
            //condi1 && condi2 => true
            //PARA TER ENTRADA GRATUITA: 
            // SERMULHER && IDADE >= 25 -> FALSE 
            // TRUE && TRUE -> TRUE
            // FALSE && FALSE -> FALSE
            // FALSE && TRUE -> FALSE
            //true && false -> FALSE

            /*
                        Console.WriteLine("Digite sua idade:");
                        int idade = int.Parse(Console.ReadLine());

                        if (idade >= 0 && idade <= 11)
                        {
                            Console.WriteLine("Você é uma criança  ");
                        } else if (idade >= 12 && idade <= 18)
                        {
                            Console.WriteLine("Você é um adolescente!");
                        } else if ( idade >=19 && idade <=60 )
                        {
                            Console.WriteLine("Você é um adulto ");
                        } else
                        {
                            Console.WriteLine("Você é um  idoso");
                        }

                        Console.ReadLine(); ;
            */





            //  ExibirMsg();
            /* GerarPreco(60);
             GerarPreco(7856 );
             GerarPreco(25);
             GerarPreco(-32);
             GerarPreco(-598);
            */


            /*  string valor = Console.ReadLine();
              Console.WriteLine(valor);
              Console.ReadLine(); 



               void ExibirMsg()
              {
                  Console.WriteLine("Esse sistema é bom ");
                  Console.WriteLine("Estou usando funçoes");
                  Console.WriteLine("Bem vindo");
                  Console.WriteLine("Guia de programador ! ");


              }

              void GerarPreco (int preco )
              {
                  int precoAbs = Math.Abs(preco);
                  int valorFinal = precoAbs + (2 * precoAbs);
                  Console.WriteLine("Valor final: " + valorFinal);


              }

               static void Somar  (int a, int b, int c)
              {
                  int resultadoFinal = a + b + c;




              }*/

            /* string[] produtos = new string[5]
             {
                 "Sea thieves",
                 "FIFA",
                 "HALF - LIFE",
                 "minecraft",
                 "Portal" 


             };

             Console.WriteLine(produtos[0]);

             Console.ReadLine();
            */


            /*string cor = "preto";

        switch(cor)
        {
            case "Vermelho":

                Console.WriteLine("Sua cor favorita é vermelho! ");
                break;

            case "Amarelo":
                Console.WriteLine("Sua cor favorita é Amarelo");
                break; 

            case "Azul":
                Console.WriteLine("Sua cor favorita é Azul");
                break;

            default:
                Console.WriteLine("COR NAO IDENTIFICADA!");
                break;

        }
            */

            /*
                        Cor corFavorita = Cor.Vermelho;
                        Cor corFavoritaCarla = Cor.Azul;


                        Console.WriteLine((int)corFavorita);
                        Console.WriteLine(corFavoritaCarla);


                        Console.ReadLine();


                        */

            /*   Console.WriteLine("Selecione uma das opções");
               Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
               int index = int.Parse(Console.ReadLine());

               Opcao opcaoSelecionada = (Opcao)index;

               Console.WriteLine(opcaoSelecionada);


               switch(opcaoSelecionada)
               {
                   case Opcao.Criar:
                       Console.WriteLine("Voce quer criar algo");
                       break;
                   case Opcao.Deletar:
                       Console.WriteLine ("DELETE !");
                       break;
                   case Opcao.Editar:
                       Console.WriteLine("EDITE AQUI!");
                       break;
                   case Opcao.Atualizar:
                       Console.WriteLine("Atualizado");
                       break;
                   case Opcao.Listar:
                       Console.WriteLine("Listado!");
                       break;



               }
            */

            /*   int contador = 0;
               while ( contador < 10)
               {
                   Console.WriteLine("Rodando!");
                   Console.WriteLine(contador);
                   contador = contador + 1;
               }

               */
            /*int contador2 = 0;
            do
            {
                Console.WriteLine("do While!");
                contador2++;
            } while (1000 < 10);

           

            */

            /*   String[] palavras = {"Lucas" , "Eduardo", "Guia do prog", "Vasco", " NodeJS", "Curso de Java", "Alura"}

               foreach(String palavra in palavras) //Para cada palavra no array palavras, repita palavras
               {
                   Console.WriteLine("FOREACH RODANDO!");
                   Console.WriteLine(palavra);
               }
            */

            String[] palavras = { "Lucas", "Eduardo", "Guia do prog", "Vasco", " NodeJS", "Curso de Java", "Alura" }

           
            
               for( int contador= 0; contador < 10; contador++)
                {
                Console.WriteLine(contador);
                }
                
        
            Console.WriteLine("FIM!");
            Console.ReadLine();




        }
    }
}