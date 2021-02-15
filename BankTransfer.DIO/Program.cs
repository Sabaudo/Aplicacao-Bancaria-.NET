using System;
using System.Collections.Generic;

namespace BankTransfer.DIO
{
    class Program
    {
        static void Main(string[] args){
           List<Conta> listContas = new List<Conta>();
           int op, inputTipoConta;
           string inputNome;
           double inputSaldo, inputCredito;
           do{
               Console.WriteLine("1 - Registrar conta no banco");
               Console.WriteLine("2 - Efetuar saque");
               Console.WriteLine("3 - Efetuar depósito");
               Console.WriteLine("4 - Efetuar transferência");
               Console.WriteLine("5 - Listar contas");
               Console.WriteLine("0 - Sair do app");
               op = int.Parse(Console.ReadLine());

               if(op == 1){
                    Console.WriteLine("Digite 1 para pessoa física ou 2 para pessoa jurídica: ");
                    inputTipoConta = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Insira o nome do proprietário da conta: ");
                    inputNome = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Insira o saldo da conta: ");
                    inputSaldo = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Insira o crédito da conta: ");
                    inputCredito = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Conta newAccount = new Conta((TipoConta)inputTipoConta, inputNome, inputCredito, inputSaldo);
                    listContas.Add(newAccount);
               }
           }while(op != 0);
        }
    }
}
