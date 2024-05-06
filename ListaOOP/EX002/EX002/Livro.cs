namespace exe002;

public class Livro
{
    public String titulo{get;set;}
    public String autor{get;set; }

    public string ImprimiInfo(Livro l)
    {
        return this.titulo + " " + this.autor;
    }
}
