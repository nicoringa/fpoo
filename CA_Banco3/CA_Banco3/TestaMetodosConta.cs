using CA_Banco3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Banco3
{
    class TestaMetodosConta
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(123);

            Conta c = new Conta(a);

            Console.WriteLine("Chamando o método depositar passando o valor 1000");
            c.Depositar(1000);
            c.ImprimirExtrato();

            Console.WriteLine("=======================");

            Console.WriteLine("Chamando o método sacar passando o valor 100");
            c.Sacar(100);
            c.ImprimirExtrato();

            Console.WriteLine("=======================");

            double saldoDisponivel = c.consultarSaldoDisponivel();
        }
    }
}
