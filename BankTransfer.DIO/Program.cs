using System;
using System.Collections.Generic;

namespace BankTransfer.DIO
{
    class Program
    {
        static void Main(string[] args){
           List<Conta> listContas = new List<Conta>();
           int op, inputTipoConta, inputNumConta, inputContaOrigem, inputContaDestino;
           string inputNome;
           double inputSaldo, inputCredito, inputSaque, inputDeposito;
           do{
               Console.WriteLine();
               Console.WriteLine("1 - Registrar conta no banco");
               Console.WriteLine("2 - Efetuar saque");
               Console.WriteLine("3 - Efetuar depósito");
               Console.WriteLine("4 - Efetuar transferência");
               Console.WriteLine("5 - Listar contas");
               Console.WriteLine("6 - Limpar tela");
               Console.WriteLine("0 - Sair do app");
               Console.WriteLine();
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
               if(op == 2){
                    Console.WriteLine("Seleciona a conta: ");
                    inputNumConta = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Insira o valor de saque: ");
                    inputSaque = double.Parse(Console.ReadLine());
                    listContas[inputNumConta].Sacar(inputSaque);
               }
               if(op == 3){
                    Console.WriteLine("Selecione a conta: ");
                    inputNumConta = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Insira o valor para depósito: ");
                    Console.WriteLine();
                    inputDeposito = double.Parse(Console.ReadLine());
                    listContas[inputNumConta].Depositar(inputDeposito);
               }
               if(op == 4){
                    Console.WriteLine("Insira a conta de origem: ");
                    inputContaOrigem = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Insira a conta de destino: ");
                    inputContaDestino = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Digite o valor da transferencia: ");
                    double inputValorTransf = double.Parse(Console.ReadLine());

                    listContas[inputContaOrigem].Transferencia(inputValorTransf, listContas[inputContaDestino]);
               }
               if(op == 5){
                   foreach(var a in listContas){
                        if(listContas.Count > 0){
                            Console.WriteLine(a.ToString());
                        }else{
                            Console.WriteLine("Não há clientes registrados!");
                            Console.WriteLine();
                        }
                   }
               }
               if(op == 6){
                   Console.Clear();
               }
           }while(op != 0);
            Console.WriteLine("Saindo do app. . .");

        }
    }
}
