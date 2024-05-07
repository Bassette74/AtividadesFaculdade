namespace ContaBancaria;

public class ContaPoupanca : IContabancaria
{
    public ContaPoupanca(int numeroConta, decimal saldo)
    {
        NumeroConta = numeroConta;
        this.saldo = saldo;
    }

    public int NumeroConta{ get; set; }
    public decimal saldo{ get; set; }



        
public void depositar( decimal valor){
       saldo += valor;
       Console.WriteLine("Saldo atual de R$" + saldo);
        
    }
   
    public void Sacar(decimal valor){
        if(saldo >= valor){
            saldo -= valor;
            Console.WriteLine("Saldo atual de R$" + saldo);
        }
        else{
            Console.WriteLine("Saldo insuficiente");
        
         }
    }
}
