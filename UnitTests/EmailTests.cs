using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class EmailTests
    {
        [Test]
        public void InstantiateValidEmailReturnsObjectCorrectly()
        {
            var email = new Email("valid@address.com");
            Assert.IsNotNull(email);
            Assert.AreEqual("valid@address.com", email.EmailAddress);
        }

        [TestCase("invalidaddress.com")]
        [TestCase("i.com")]
        [TestCase("@.com")]
        [TestCase("@")]
        public void InstantiateInvalidEmailThrowsException(string testEmail)
        {
            Assert.Throws<ArgumentException>(() => new Email(testEmail));
        }

        
    }
}
