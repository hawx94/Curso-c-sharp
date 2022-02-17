using System;
using System.Collections.Generic;
using System.Text;

namespace Aula
{
    class Empregados
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Empregados(int id,string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }


        public void AumentoDeSalarioDofuncionario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2");


        }


    }
}
