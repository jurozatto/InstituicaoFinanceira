using ControleContas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.Mime.MediaTypeNames;

namespace ControleContas.Tests
{
    [TestClass]
    public class ContaTests
    {
        [TestMethod]
        public void TestarDepositoPositivo()
        {
            Cliente cliente = new Cliente("Júlia", "12345678901", 2005);
            Conta conta = new Conta(12345, 50, cliente); // saldo inicial válido

            conta.Depositar(100);

            Assert.AreEqual(150, conta.Saldo);
        }

        [TestMethod]
        public void TestarDepositoNegativo()
        {
            Cliente cliente = new Cliente("Cristiane", "98765432100", 1978);
            Conta conta = new Conta(12345, 50, cliente); // saldo inicial válido

            conta.Depositar(-50);

            Assert.AreEqual(50, conta.Saldo); // saldo não deve mudar
        }
    }
}
