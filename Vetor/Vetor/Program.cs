using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartamentos[] vectAp = new Apartamentos[10];
            Console.WriteLine("Número de estudantes: ");
            int NumeroDeEstudantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumeroDeEstudantes; i++)
            {
                Console.WriteLine("Nome do aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email do aluno: ");
                string email = Console.ReadLine();
                Console.WriteLine("Número do quarto: ");
                int numeroDoQuarto = int.Parse(Console.ReadLine());
                vectAp[numeroDoQuarto] = new Apartamentos { Nome = nome, EMail = email, NumeroDoQuarto = numeroDoQuarto };
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vectAp[i] != null)
                {
                    Console.WriteLine(vectAp[i]);
                }
            }
        }
    }
}
