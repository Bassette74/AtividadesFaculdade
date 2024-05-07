// See https://aka.ms/new-console-template for more information
using ContaBancaria;

Console.WriteLine("Hello, World!");

 ContaPoupanca contaPoupanca= new ContaPoupanca(123456 , 100);
 contaPoupanca.Sacar(50);
 contaPoupanca.depositar(200);
 contaPoupanca.Sacar(1000);

 Console.WriteLine("--------------------------------------------------------");

 ContaCorrente contaCorrente = new ContaCorrente(123456, 1000);
 contaCorrente.depositar(500);
 contaCorrente.Sacar(700);
 contaPoupanca.Sacar(2000);

 Console.WriteLine("-------------------------------------------");
 IContabancaria contacorrente = new ContaCorrente(123465,1000);
 contacorrente.depositar(500);
 contacorrente.Sacar(700);


 IContabancaria Contapoupanca = new ContaPoupanca(123456, 100);
 Contapoupanca.depositar(500);
 Contapoupanca.Sacar(700);

Transacao trans = new Transacao();
trans.tipo = "deposito";
trans.valor = 1000;
Console.WriteLine(Contapoupanca.saldo);
trans.TransCCpCP(contaCorrente, contaPoupanca, 1000, " tranferencia");
Console.WriteLine(Contapoupanca.saldo);

 




