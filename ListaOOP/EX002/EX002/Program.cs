// See https://aka.ms/new-console-template for more information
using exe002;

Console.WriteLine("Hello, World!");


Pessoa p = new Pessoa();
p.cpf = "120.947.179.50";
p.nome = "Felipe";
Console.WriteLine("cpf = " + p.cpf + " Nome = " + p.nome);
Livro l = new Livro();
l.titulo = "lala";
l.autor = "lolo";

p.ReceberLivro(l);
Console.WriteLine(l.ImprimiInfo);
