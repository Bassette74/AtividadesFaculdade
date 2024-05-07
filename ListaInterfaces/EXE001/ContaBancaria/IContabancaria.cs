namespace ContaBancaria;

public interface IContabancaria
{
    public int NumeroConta{ get; set; }
    public decimal saldo{ get; set; }
    public void depositar(decimal valor);

    public void Sacar(decimal valor);
}
