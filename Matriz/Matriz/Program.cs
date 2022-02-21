using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de colunas da Matriz");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de linhas da Matriz");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for(int i = 0; i< m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                    
                }
                                
            }
            Console.WriteLine();
            Console.WriteLine("Número a ser mostrado: ");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
               
                for (int j = 0; j < n; j++)
                {
                   if(matriz[i,j] == numeroEscolhido)
                    {
                        
                        Console.WriteLine("Posição: "+ i+"," + j);     
                       if(j<n-1)
                        {                        
                          Console.WriteLine("Direita " + matriz[i, j + 1]);
                        }
                      
                        if(j>0)
                        {
                          Console.WriteLine("Esquerda " + matriz[i, j - 1]);
                        }
                            
                        if(i>0)
                        {
                          Console.WriteLine("Cima " + matriz[i - 1, j]);
                        }
                           
                        if(i< m-1)
                        {
                          Console.WriteLine("Baixo " + matriz[i + 1, j]);
                        }
                            
                        
                             
                    }

                }

            }


        }
    }
}
