namespace Prod;

public class Vestuario : Produto
{
    public string Tamanho { get; set; }

    public Vestuario(string nome, decimal preco, string tamanho) : base(nome, preco)
    {
        Tamanho = tamanho;
    }
}
