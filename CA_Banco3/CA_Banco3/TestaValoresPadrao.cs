using CA_Banco3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Banco3
{
    class TestaValoresPadrao
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia(123);

            Conta c = new Conta(a);

            Console.WriteLine("Valores Padrão");
            Console.WriteLine("Número: " + c.numero);
            Console.WriteLine("Saldo: " + c.saldo);
            Console.WriteLine("Limite: " + c.limite);
        }
    }
}
