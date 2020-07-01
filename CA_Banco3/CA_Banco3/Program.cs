using System;
using CA_Banco3.Model;

//namespace CA_Banco3
//{
    //class Program
    //{
        //static void Main(string[] args)
        //{
            ////Vamos instanciar dois objetos
            ////1. Objeto Cliente
            //Cliente c1 = new Cliente();

            ////2.Objeto CartaoDeCredito
            //CartaoDeCredito cdc = new CartaoDeCredito();

            ////Ligação
            //cdc.cliente = c1; 

            //Console.Write("Digite o número do cartão: ");
            //cdc.numero = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite a data de validade do cartão: ");
            //cdc.dataDeValidade = Console.ReadLine();

            //Console.Write("Digite o nome do cliente: ");
            //cdc.cliente.nome = Console.ReadLine();

            //Console.WriteLine("Dados do cliente");
            //Console.WriteLine($"Número do cartão: {cdc.numero}");
            //Console.WriteLine($"Data de validade: {cdc.dataDeValidade}");
            //Console.WriteLine($"Nome do cliente: {cdc.cliente.nome}");

            //Console.ReadKey();

//            Conta novaConta = new Conta();

//            Console.WriteLine($"Saldo inicial: {novaConta.saldo}");

//            Console.Write("Digite o valor do depósito: ");
//            double vlr_dep = Convert.ToDouble(Console.ReadLine());

//            novaConta.Depositar(vlr_dep);

//            Console.WriteLine($"Saldo após o depósito: {novaConta.saldo}");
//            Console.WriteLine("Depósito efetuado com sucesso!!!");

//            Console.WriteLine("Digite o valor do saque");
//            double vlr_sac = Convert.ToDouble(Console.ReadLine());

//            //Método com ou sem retorno
//            //novaConta.Sacar(vlr_sac);

//            //Console.WriteLine($"Saldo após o saque: {novaConta.saldo}");
//            //Console.WriteLine("Saque efetuado com sucesso!!!");

//            //Método retornando um valor booleano
//            bool deuCerto = novaConta.Sacar(vlr_sac);

//            //Essa variável deuCerto é do tipo booleana e pode assumir dois valores:
//            //true ou false

//            if (deuCerto)
//            {
//                Console.WriteLine("Saque efetuado com sucesso!!!");
//                Console.WriteLine($"Saldo após o saque: {novaConta.saldo}");
//            }
//            else
//            {
//                Console.WriteLine("Saldo insuficiente para o valor do saque");
//                Console.WriteLine($"Você excedeu em {vlr_sac - novaConta.saldo}");
//            }

//            Console.ReadKey();      
//        }
//    }
//}
