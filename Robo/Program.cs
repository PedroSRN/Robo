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

            string E, D;
            string opcao = "";

            Console.WriteLine("ROBO MARTE 1.0");

            Console.WriteLine("Posição Inicial de x e y é: 0,0");

            Console.WriteLine("Digite M para o robo mover-se:");

            opcao = Console.ReadLine();
            
            Console.ReadLine();

            string[,] instrucoes = new string[5, 5];
            Console.WriteLine("Coordenadas: ");
            instrucoes[2, 2] = "posicao x e y é: 2,2";
            instrucoes[2, 1] = "posicao x e y é: 2,1";
            instrucoes[2, 0] = "posicao x e y é: 2,0";
            instrucoes[1, 0] = "posicao x e y é: 1,0";
            instrucoes[0, 0] = "posicao x e y é: 0,0";


            switch (opcao)
            {
                case "M":
                    foreach (string i in instrucoes)
                    {
                        Console.WriteLine("M");
                       
                        Console.WriteLine(i);
                    }
                    break;
                    
                }


        }
    }
}
