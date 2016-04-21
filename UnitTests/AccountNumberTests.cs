using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace UnitTests
{
    [TestFixture]
    public class AccountNumberTests
    {
        [Test]
        public void InstantiateValidAccountNumberReturnObjectCorrectly()
        {
            var accNum = new AccountNumber("12345678");
            Assert.IsNotNull(accNum);
            Assert.AreEqual("12345678",accNum.AccountNum);
        }

        [TestCase("123456789")]
        [TestCase("1234567")]
        public void InstantiateInvalidAccountNumber(string testAccountNumber)
        {
            Assert.Throws<ArgumentException>(() => new AccountNumber(testAccountNumber));
            
        }

        

        
    }
}
