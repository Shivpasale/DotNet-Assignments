using NUnit.Framework;
using Moq;

[TestFixture]
public class CustomerServiceTests
{
    [Test]
    public void GetName_Test()
    {
        var mock = new Mock<ICustomerRepository>();

        mock.Setup(x => x.GetCustomerName())
            .Returns("Shivam");

        var service = new CustomerService(mock.Object);

        var result = service.GetName();

        Assert.AreEqual("Shivam", result);
    }
}