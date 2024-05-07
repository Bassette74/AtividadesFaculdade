namespace EX001;

public class Carro : Veiculo
{

    public int NPortas {get;set;}
    public Carro(string marca, string modelo , int NPortas) : base(marca, modelo)
    {
        this.NPortas = NPortas;
    }
    public override void ligar()
    {
        Console.WriteLine("Ligueii");
        
    }
    public override void desligar()
    {
        Console.WriteLine("Desliguei");
    }

}
