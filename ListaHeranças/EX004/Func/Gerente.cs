namespace Func;

public class Gerente : Funcionario
{
    public decimal Comissao { get; set; }

    public Gerente(string nome, decimal salario, decimal comissao) : base(nome, salario)
    {
        Comissao = comissao;
    }
}
