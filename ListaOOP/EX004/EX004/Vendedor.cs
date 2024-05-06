namespace EX004;

public class Vendedor
{
    public Vendedor(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }

    public string nome{ get; set; }
    public string cpf { get; set;}
}
