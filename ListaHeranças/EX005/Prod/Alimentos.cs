namespace Prod;

public class Alimento : Produto
{
    public DateTime DataValidade { get; set; }

    public Alimento(string nome, decimal preco, DateTime dataValidade) : base(nome, preco)
    {
        DataValidade = dataValidade;
    }
}