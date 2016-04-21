using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL;


namespace UnitTests
{
    [TestFixture]
    public class PhoneNumberTests
    {
         [Test]
         public void InstantiateValidPhoneNumberReturnObjectCorrectly()
         {
             var phoneNumber = new Phone("123-1234567"); 
             Assert.IsNotNull(phoneNumber);
             Assert.AreEqual("123-1234567",phoneNumber.PhoneNumber);
         }

         [TestCase("123-12345678")]
         [TestCase("123-123456")]
         [TestCase("1231234567")]
         public void IstantiateInvalidPhoneNumberLengthThrowsException(string phoneNumber)
         {
             Assert.Throws<ArgumentException>(() => new Phone(phoneNumber));
             
         }

                  
    }
}
