// See https://aka.ms/new-console-template for more information
using EX004;

    Cliente cliente = new Cliente("123.456.789-00", "João da Silva");
    Pedido pedido = new Pedido(cliente, "2022-01-01", "Maria Souza", new List<Produto>
    {
            new Produto("Produto 1", 10.0m),
            new Produto("Produto 2", 20.0m)
    });

            Console.WriteLine($"Cliente: {pedido.Cliente.Nome} ({pedido.Cliente.Cpf})");
            Console.WriteLine($"Data: {pedido.Data}");
            Console.WriteLine($"Vendedor: {pedido.Vendedor}");

        foreach (var produto in pedido.Produtos)
    {
        Console.WriteLine($"Produto: {produto.Nome} ({produto.Preco:C})");
    }