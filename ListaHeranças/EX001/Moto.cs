namespace EX001;

public class Moto : Veiculo
{
    public int cilindrada {get;set;}
    public Moto(string marca, string modelo , int cilindrada) : base(marca, modelo)
    {
        this.cilindrada = cilindrada;
    }
}
