using ControleContas;
using System;

Cliente cliente1 = new Cliente("Júlia", "12345678901", 2005);
cliente1.MostrarDados();

Conta conta1 = new Conta(123456789, cliente1);
Conta conta2 = new Conta(654321, cliente1);

conta1.Depositar(1000m);
conta2.Depositar(2341.42m);

Console.WriteLine($"\nTitular: {cliente1.Nome} (CPF: {cliente1.CPF})");
Console.WriteLine($"Conta 1: número = {conta1.Numero}, saldo = {conta1.Saldo:C}");
Console.WriteLine($"Conta 2: número = {conta2.Numero}, saldo = {conta2.Saldo:C}");

Console.WriteLine($"Saldo após depósito: {conta1.Saldo:C}");

conta1.Sacar(300m);
Console.WriteLine($"Saldo após saque: {conta1.Saldo:C}");

conta1.Sacar(800m);

decimal totalContas = conta1.Saldo + conta2.Saldo;
Console.WriteLine($"\nSaldo total das duas contas: {totalContas:C}");


//Conta com maior saldo
Console.WriteLine($"\nConta com maior saldo: {Conta.ContaMaiorSaldo.Numero} (Saldo: {Conta.ContaMaiorSaldo.Saldo:C})");


// Saldo total geral
Console.WriteLine($"\nSaldo total geral atual: {Conta.SaldoTotalGeral:C}");



//crie um atributo saldo na classe Conta cuja propriedade seja somente leitura

//TDD
//Crie um projeto de teste para testar a classe Conta, ele deverá testar um método depositar.
//O método depositar devrá receber um valor decimal positivo o incrementar e saldo da conta