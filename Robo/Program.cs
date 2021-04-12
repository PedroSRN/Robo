using System;

namespace Robo
{
    class Program
    {
        #region Especificações #1
        //-1 A posição de um robô é representada por uma combinação de coordenadas X e Y.
        //-2 E também uma letra representando a direção que ele está olhando.

        #endregion

        #region Especificações #2
        #endregion
        static void Main(string[] args)
        {

            string i = "";
            string localizacao;

            Console.WriteLine("ROBO MARTE 1.1");

            Console.WriteLine("As dimenções da área a ser estudada são '5,5'");

            Console.WriteLine("Digite a localização inicial do robo: ");

            localizacao = Console.ReadLine();

            Console.WriteLine("Digite as cordenadas q deseja q o robo faça 'M','E','D':");

            i = Console.ReadLine();


            string[,] instrucoes = new string[5,5];
           
            

            /*Console.WriteLine(tamanho);*/

            foreach (string cmd in instrucoes)
            {
                if ( i == "m" || i == "M")
                {
                    Console.WriteLine("Moveu M");
                   
                    i = Console.ReadLine();
                    
                }

                else if (i == "d" || i == "D")
                {
                    Console.WriteLine("Girou 90° a direita");
                    
                    i = Console.ReadLine();

                }

                else if (i == "e" || i == "E")
                {
                    Console.WriteLine("Girou 90° a esquerda");
                    
                     i = Console.ReadLine();
                    
                }
            }

                    
                         


        }
    }
}
