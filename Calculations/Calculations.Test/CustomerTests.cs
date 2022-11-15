using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void ChceckCustomerNameNotEmpty() 
        {
            Customer customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

        [Fact]
        public void CheckLegitForDiscount() 
        {
            Customer customer = new Customer();
            Assert.InRange(customer.Age, 25, 35);
        }

        [Fact]
        public void GetOrders_GivenAName_NameNotNull() 
        {
            Customer customer = new Customer();
            Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
        }

        [Fact]
        public void LoyalCustomerForOrdersGreaterThen100()
        {
            Customer customer = CustomerFactory.CreateCustomerInstance(99);
            Assert.IsType<LoyalCustomer>(customer);
        }
    }
}
