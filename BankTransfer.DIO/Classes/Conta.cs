using System;
namespace BankTransfer.DIO
{
    public class Conta
    {
        string nome;
        double credito;
        double saldo;
        TipoConta tipoConta;

        private string Nome { get{return nome;} set{nome = value;} }

        private double Credito { get{return credito;} set{credito = value;} }

        public double Saldo { get{return saldo;} set{saldo = value;} }

        public TipoConta TipoConta { get; set; }

        public Conta(TipoConta tipoConta, string nome, double credito, double saldo)
        {
            this.tipoConta = tipoConta;
            this.nome = nome;
            this.saldo = saldo;
            this.credito = credito;
        }

        public bool Sacar(double valorSaque){
            Console.WriteLine($"Valor do saque: R${valorSaque}");
            Console.WriteLine();
            if(this.saldo - valorSaque < (this.credito*-1)){
                Console.WriteLine("O saque não pôde ser efetuado!");
                return false;
            }else{
                this.saldo -= valorSaque;
                Console.WriteLine("Saque efetuado com sucesso!");
                Console.WriteLine();
                Console.WriteLine($"Valor atual do saldo: R${this.saldo}");
                return true;
            }
        }

        public void Depositar(double valorDeposito){
            Console.WriteLine($"Saldo antes do depósito: R${this.saldo}");
            Console.WriteLine();
            if(valorDeposito >= 0){
                this.saldo += valorDeposito;
                Console.WriteLine("Depósito efetuado com sucesso!");
                Console.WriteLine();
                Console.WriteLine($"Saldo depois do depósito: R${this.saldo}");
            }else{
                Console.WriteLine("Não é possível depositar um valor menor ou igual a R$0");
            }
        }

        public void Transferencia(double valorTransferencia, Conta contaDestino){
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
                Console.WriteLine($"O valor de R${valorTransferencia} foi transferido com sucesso!");
            }
        }

        public override string ToString(){
            return "Tipo da conta" + this.tipoConta + "--" +  "Nome do proprietario da conta: " + this.nome + 
            "--" + "Saldo da conta: " + this.saldo + "--" + "Credito da conta: " + this.credito;
        }
    }
}