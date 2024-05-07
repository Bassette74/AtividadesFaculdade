
namespace ContaBancaria;

public class Transacao 
{
    

    
    

    public string tipo { get; set; }

    public decimal valor { get; set; }
    public string V { get; }

    public string exibirinfo(){
        Console.WriteLine(tipo + " " + valor);
        return tipo + " " + valor;
    }

    public void TransCCpCP(ContaCorrente cc , ContaPoupanca cp , decimal valor , string tipo){
        
        cc.saldo -= valor;
        cp.saldo += valor;
        Console.WriteLine("foi tranferido um valor de " + valor + "para a conta coupança");
    } 

    public void TransCPpCC(ContaCorrente cc , ContaPoupanca cp , decimal valor , string tipo){
        
        cc.saldo -= valor;
        cp.saldo += valor;
        Console.WriteLine("foi tranferido um valor de " + valor + "para a conta Corrente");
    }

    
}
