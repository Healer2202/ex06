using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }

        [TestMethod]
        public void Testdposit()
        {
            BankAccount acc2 = new BankAccount(200000);

            Assert.AreEqual(400000, acc2.deposit(200000));
        }
        [TestMethod]
        public void TestdWithDraw()
        {
            BankAccount acc3 = new BankAccount(200000);
            Assert.AreEqual(100000, acc3.withDraw(100000));
        }
    }
}
