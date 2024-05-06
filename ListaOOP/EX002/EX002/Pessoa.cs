namespace exe002;

public class Pessoa
{
    public string nome { get; set;}
    public string cpf { get; set;}

    List<Livro> livros = new List<Livro>();

    public string ReceberLivro(Livro l){
        livros.Add(l);
        Console.WriteLine("Livro adicionado");
        return "Livro Adicionado";
        
        
        
    }

}
