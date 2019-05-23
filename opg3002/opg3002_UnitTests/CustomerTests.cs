using opg3002_ShoppingCL;
using System;
using Xunit;

namespace opg3002_UnitTests
{
    public class CustomerTests
    {
        [Fact]
        public void TestCustomerGetTimeSinceFirstRegistration()
        {
            //a customer with registration date 10 days ago
            Customer c = new Customer("Firstname", "Lastname");
            c.setFirstRegistered(DateTime.Now.AddDays(-10));
            int ExpectedResult = 10;
            Assert.Equal(ExpectedResult, c.GetTimeSinceFirstRegistration());
        }

        [Fact]
        public void TestCustomerGetTimeToEligibility()
        {
            //a customer with registration date 12 days ago
            Customer c = new Customer("Firstname", "Lastname");
            c.setFirstRegistered(DateTime.Now.AddDays(-12));
            int ExpectedResult = 18;

            Assert.Equal(ExpectedResult, c.GetTimeToEligibility());
        }
    }
}
