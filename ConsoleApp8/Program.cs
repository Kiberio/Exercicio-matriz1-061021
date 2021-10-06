using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz");
            //Criação de uma variavel int e uso para armazenar o numero inteiro
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            Console.WriteLine("Digite uma matriz de ordem   EX:");
            Console.WriteLine("[xx xx xx]");
            Console.WriteLine("Lembrando que o tamanho da matriz depende do tamanho digitado acima");
            for (int i = 0; i < n; i++) 
            {
                //Variavel que armazena cada linha da matriz e dividir cada numero
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
             Console.WriteLine("Diagonal Principal: ");
            //For para imprimir a Diagonal Principal 
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            
            Console.WriteLine();
            //Conta a quantidade de numeros negativos
            int count = 0;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (mat[i,j] < 0) 
                    {
                        count++;
                    }
                }
            }
            //Imprimir a quantidade total de numeros negativos
            Console.WriteLine("Numeros negativos: " + count);
            Console.ReadKey();
        }
    }
}

