namespace EX004;

public class Pedido
{
    public Cliente Cliente { get; set; }
    public string Data { get; set; }
    public string Vendedor { get; set; }
    public List<Produto> Produtos { get; set; }

    public Pedido(Cliente cliente, string data, string vendedor = null, List<Produto> produtos = null)
    {
        Cliente = cliente;
        Data = data;
        Vendedor = vendedor;
        Produtos = produtos?? new List<Produto>();
    }
}
