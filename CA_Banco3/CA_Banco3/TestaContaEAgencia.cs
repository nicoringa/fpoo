using CA_Banco3.Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CA_Banco3
{
    class TestaContaEAgencia
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(1234);
            Conta c = new Conta(a);

            c.numero = 123;
            c.saldo = 1000.0;
            c.limite = 500;

            Console.WriteLine("Dados da agência");
            Console.WriteLine("Número: " + a.numero);

            Console.WriteLine("============================");

            Console.WriteLine("Dados da conta");
            Console.WriteLine("Número: " + c.numero);
            Console.WriteLine("Saldo: " + c.saldo);
            Console.WriteLine("Limite: " + c.limite);

            Console.WriteLine("===============================");

            c.agencia = a;

            Console.WriteLine("Dados da agência obtidos através da conta");
            Console.WriteLine(c.agencia.numero);

            Console.ReadKey();
        }
    }
}
