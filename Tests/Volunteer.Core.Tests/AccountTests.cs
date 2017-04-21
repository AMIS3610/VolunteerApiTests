using System;
using Volunteer.Core;
using Xunit;

namespace BuckeyeStore.Core.Tests
{
    public class AccountTests
    {
        [Fact]
        public void Test1()
        {
            var account = new Account
            {
                Id = 1,
                UserName = "HeckinSnek",
                Password = "OhboyIjustpoopedmypants12345"
            };

            var listing = new Listing
            {
                Id = 1,
                EventName = "Outreach",
                ProducerName = "United"              
            };
           
            //Act
            account.AddListing(listing);

            //Assert
            Assert.NotNull(account.Id);
            Assert.NotNull(account.UserName);
            Assert.NotNull(account.Password);

        }
    }
}
