using ControleContas;
using System;

Banco banco1 = new Banco("Banco do Brasil", 1);


Agencia agencia1 = new Agencia(1001, "70070-900", "(61) 4002-8922", banco1);
Agencia agencia2 = new Agencia(1002, "01310-930", "(11) 99999-0000", banco1);


Cliente cliente1 = new Cliente("Júlia", "12345678901", 2005);
Cliente cliente2 = new Cliente("Cristiane", "98765432100", 1978);


Conta conta1 = new Conta(123456789, 1000m, cliente1, agencia1);
Conta conta2 = new Conta(654321, 2341.42m, cliente2, agencia2);


Console.WriteLine("\n--- Situação Inicial ---");
ExibirConta(conta1);
ExibirConta(conta2);


Console.WriteLine("\n--- Realizando Saque ---");
conta1.Sacar(300m);


Console.WriteLine("\n--- Transferência ---");
conta1.Transferir(200m, conta2);


Console.WriteLine("\n--- Depósito ---");
conta2.Depositar(500m);


Console.WriteLine("\n--- Situação Final ---");
ExibirConta(conta1);
ExibirConta(conta2);


decimal totalContas = conta1.Saldo + conta2.Saldo;
Console.WriteLine($"\nSaldo total das duas contas: {totalContas:C}");
Console.WriteLine($"Conta com maior saldo: {Conta.ContaMaiorSaldo.Numero} (Saldo: {Conta.ContaMaiorSaldo.Saldo:C})");
Console.WriteLine($"Saldo total geral atual: {Conta.SaldoTotalGeral:C}");


static void ExibirConta(Conta conta)
{
    Console.WriteLine(
        $"Conta: {conta.Numero}, Titular: {conta.Titular.Nome}, Agência: {conta.Agencia.Numero}, Banco: {conta.Agencia.Banco.Nome}, Saldo: {conta.Saldo:C}"
    );
}

//crie um atributo saldo na classe Conta cuja propriedade seja somente leitura

//TDD
//Crie um projeto de teste para testar a classe Conta, ele deverá testar um método depositar.
//O método depositar devrá receber um valor decimal positivo o incrementar e saldo da conta