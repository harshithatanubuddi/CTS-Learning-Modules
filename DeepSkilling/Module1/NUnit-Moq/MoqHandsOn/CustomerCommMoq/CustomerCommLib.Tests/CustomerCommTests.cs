using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommLib.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        [Test]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            // Arrange
            Mock<IMailSender> mockMail =
                new Mock<IMailSender>();

            mockMail.Setup(x =>
            x.SendMail(It.IsAny<string>(),
            It.IsAny<string>()))
            .Returns(true);

            CustomerComm customer =
                new CustomerComm(mockMail.Object);

            // Act
            bool result =
                customer.SendMailToCustomer();

            // Assert
            Assert.That(result, Is.True);
        }
    }
}