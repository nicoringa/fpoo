using CA_Banco3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Banco3
{
    class TestaClienteECartao
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito(111111);

            c.nome = "Rafael Cosentino";
            c.codigo = 123;

            cdc.dataDeValidade = "12/12/18";

            Console.WriteLine("Dados do cliente");
            Console.WriteLine("Nome: " + c.nome);
            Console.WriteLine("Código: " + c.codigo);

            Console.WriteLine("==========================");

            Console.WriteLine("Dados do cartão");
            Console.WriteLine("Número: " + cdc.numero);
            Console.WriteLine("Data de validade: " + cdc.dataDeValidade);

            Console.WriteLine("===========================");

            cdc.cliente = c;
            Console.WriteLine("Dados do cliente obtidos através do cartão");
            Console.WriteLine(cdc.cliente.nome);
            Console.WriteLine(cdc.cliente.codigo);

            Console.ReadKey();
        }
    }
}
