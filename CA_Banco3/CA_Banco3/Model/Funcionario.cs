using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Banco3.Model
{
    class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public static double valeRefeicaoDiario { get; set; }

        public void AumentaSalario(double aumento)
        {
            this.salario += aumento;
        }

        public static void ReajustaValeRefeicaoDiario(double taxa)
        {
            Funcionario.valeRefeicaoDiario += Funcionario.valeRefeicaoDiario * taxa;
        }
    }
}
