namespace EX001;

public class Caminhão : Veiculo
{
    public Caminhão(string marca, string modelo , int CapcidadeCarga) : base(marca, modelo)
    {
        this.CapcidadeCarga = CapcidadeCarga;
    }

    public int CapcidadeCarga{get;set;}
    
    public override void ligar()
    {
        Console.WriteLine("carreta ligada");
    }
    public override void desligar()
    {
        Console.WriteLine("carreta desligada");
    }
}
