using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Banco3.Model
{
    public class Conta
    {
        //Atributos
        public double saldo { get; set; }
        public double limite { get; set; }
        public int numero { get; set; }
        public Agencia agencia { get; set; }

        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        //1. Método Depositar COM retorno - double
        //public double Depositar(double valor)
        //{
        //    return saldo += valor;
        //}

        //2. Método Sacar COM retorno - double
        //public double Sacar(double valor)
        //{
        //    return saldo -= valor;
        //}

        //3. Método Sacar COM retorno do tipo booleano - bool
        public bool Sacar(double valor)
      
        {
            if (this.saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public void ImprimirExtrato()//Somente dos últimos 15 dias
        {
            this.ImprimirExtrato(15);
        }
        public void ImprimirExtrato(int dias)
        {
            //Extrato
        }
        
        //saldo = 100
        //valor = 150
        //retorna?
    }
}
