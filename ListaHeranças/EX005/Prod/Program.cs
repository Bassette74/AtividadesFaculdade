// See https://aka.ms/new-console-template for more information
using Prod;


Eletronico celular = new Eletronico("Celular", 1500, "Samsung");
        Console.WriteLine("Eletrônico:");
        Console.WriteLine("Nome: " + celular.Nome);
        Console.WriteLine("Preço: " + celular.Preco);
        Console.WriteLine("Marca: " + celular.Marca);

        Alimento fruta = new Alimento("Maçã", 2.5m, new DateTime(2024, 5, 10));
        Console.WriteLine("\nAlimento:");
        Console.WriteLine("Nome: " + fruta.Nome);
        Console.WriteLine("Preço: " + fruta.Preco);
        Console.WriteLine("Data de Validade: " + fruta.DataValidade.ToShortDateString());

        Vestuario camisa = new Vestuario("Camisa Polo", 50, "M");
        Console.WriteLine("\nVestuário:");
        Console.WriteLine("Nome: " + camisa.Nome);
        Console.WriteLine("Preço: " + camisa.Preco);
        Console.WriteLine("Tamanho: " + camisa.Tamanho);
    