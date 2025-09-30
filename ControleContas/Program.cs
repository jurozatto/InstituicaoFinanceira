using ControleContas;
using System;

Conta conta1 = new Conta(123456789);
Conta conta2 = new Conta();
Console.WriteLine($"O número da conta 1 é {conta1.Numero}");
Console.WriteLine($"O número da conta 2 é {conta2.Numero}");


//crie um atributo saldo na classe Conta cuja propriedade seja somente leitura

//TDD
//Crie um projeto de teste para testar a classe Conta, ele deverá testar um método depositar.
//O método depositar devrá receber um valor decimal positivo o incrementar e saldo da conta