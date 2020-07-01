using CA_Banco3.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CA_Banco3
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Funcionario.valeRefeicaoDiario = 15;

            Console.WriteLine("Entrada dos dados do funcionário");
            Console.Write("Digite o nome: ");
            f1.nome = Console.ReadLine();

            Console.Write("Digite o salário R$ : ");
            f1.salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n\nSaída dos dados do funcionário");
            Console.WriteLine("\n\nNome: " + f1.nome +
                                "\nSalário: " + f1.salario.ToString("C") +
                                 "\nValor do VR: " + Funcionario.valeRefeicaoDiario.ToString("C"));

            Console.WriteLine("Pressione alguma tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
