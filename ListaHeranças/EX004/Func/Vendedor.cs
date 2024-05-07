namespace Func;

public class Vendedor : Funcionario
{
    public string AreaAtuacao { get; set; }

    public Vendedor(string nome, decimal salario, string areaAtuacao) : base(nome, salario)
    {
        AreaAtuacao = areaAtuacao;
    }
}