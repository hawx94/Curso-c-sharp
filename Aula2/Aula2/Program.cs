using System;
using System.Collections.Generic;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregados> listaDeEmpregados = new List<Empregados>();
            
            
            Console.WriteLine("Quantos empregados serão registrados");
            int numeroDeEmpregados = int.Parse(Console.ReadLine());
            for(int i = 0; i < numeroDeEmpregados; i++)
            {
                Console.WriteLine("Empregado " + (i+1) + ":");
                Console.WriteLine("Empregado id: " );
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Empregado Nome: ");
                string name = Console.ReadLine( );
                Console.WriteLine("Empregado Salario: ");
                double salario = double.Parse(Console.ReadLine());
                listaDeEmpregados.Add(new Empregados(id,name,salario));
                Console.WriteLine();

            }

            Console.WriteLine("Qua o id do empregado que receberá um aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Empregados emp = listaDeEmpregados.Find(x => x.Id == idAumento);
            if(emp != null)
            {
                Console.WriteLine("Valor do aumento em %: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.AumentoDeSalarioDofuncionario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id nao existente!!!");
            }


            Console.WriteLine();
            Console.WriteLine("Lista atualizada :");
            foreach (Empregados obj in listaDeEmpregados)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
