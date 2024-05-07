namespace EX001;

public class Moto : Veiculo
{
    public int cilindrada {get;set;}
    public Moto(string marca, string modelo , int cilindrada) : base(marca, modelo)
    {
        this.cilindrada = cilindrada;
    }

    public override void ligar()
    {
        Console.WriteLine("labreta ligada");
    }
    public override void desligar()
    {
        Console.WriteLine("labreta desligada");
    }
}
