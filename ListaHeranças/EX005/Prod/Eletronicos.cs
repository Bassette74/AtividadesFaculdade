namespace Prod;

public class Eletronico : Produto
{
    public string Marca { get; set; }

    public Eletronico(string nome, decimal preco, string marca) : base(nome, preco)
    {
        Marca = marca;
    }
}
