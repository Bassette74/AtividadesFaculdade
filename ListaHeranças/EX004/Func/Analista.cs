namespace Func;

public class Analista : Funcionario
{
    public int NivelExperiencia { get; set; }

    public Analista(string nome, decimal salario, int nivelExperiencia) : base(nome, salario)
    {
        NivelExperiencia = nivelExperiencia;
    }
}
