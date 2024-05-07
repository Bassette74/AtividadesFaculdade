namespace EX001;

public class Veiculo
{
    public Veiculo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    public string marca{get;set;}
    public string modelo{get;set;}

    public virtual void ligar(){
        Console.WriteLine("Ligando o carro");
    }

    public virtual void desligar(){

        Console.WriteLine("Desligando o carro");
    }
}
