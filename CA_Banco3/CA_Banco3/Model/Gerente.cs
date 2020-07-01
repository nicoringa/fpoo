using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Banco3.Model
{
    public class Gerente
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public void AumentarSalario()
        {
            this.AumentarSalario(0.1);
        }

        public void AumentarSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
    }
}
