using ControleContas;
using System;

Cliente cliente1 = new Cliente("Júlia", "12345678901", 2005);
Cliente cliente2 = new Cliente("Cristiane", "98765432100", 1978);

Conta conta1 = new Conta(123456789, 1000m, cliente1);
Conta conta2 = new Conta(654321, 2341.42m, cliente2);

Console.WriteLine("\n=== Situação Inicial ===");
Console.WriteLine($"Conta 1 - Número: {conta1.Numero}, Titular: {conta1.Titular.Nome}, Saldo: {conta1.Saldo:C}");
Console.WriteLine($"Conta 2 - Número: {conta2.Numero}, Titular: {conta2.Titular.Nome}, Saldo: {conta2.Saldo:C}");

//Sacar
Console.WriteLine("\n=== Realizando Saque ===");
conta1.Sacar(300m);

//Transferir
Console.WriteLine("\n=== Transferência ===");
conta1.Transferir(200m, conta2);

//Depositar
Console.WriteLine("\n=== Depósito ===");
conta2.Depositar(500m);

//Final
Console.WriteLine("\n=== Situação Final ===");
Console.WriteLine($"Conta 1 - Número: {conta1.Numero}, Titular: {conta1.Titular.Nome}, Saldo: {conta1.Saldo:C}");
Console.WriteLine($"Conta 2 - Número: {conta2.Numero}, Titular: {conta2.Titular.Nome}, Saldo: {conta2.Saldo:C}");

decimal totalContas = conta1.Saldo + conta2.Saldo;
Console.WriteLine($"\nSaldo total das duas contas: {totalContas:C}");
Console.WriteLine($"Conta com maior saldo: {Conta.ContaMaiorSaldo.Numero} (Saldo: {Conta.ContaMaiorSaldo.Saldo:C})");
Console.WriteLine($"Saldo total geral atual: {Conta.SaldoTotalGeral:C}");



//crie um atributo saldo na classe Conta cuja propriedade seja somente leitura

//TDD
//Crie um projeto de teste para testar a classe Conta, ele deverá testar um método depositar.
//O método depositar devrá receber um valor decimal positivo o incrementar e saldo da conta