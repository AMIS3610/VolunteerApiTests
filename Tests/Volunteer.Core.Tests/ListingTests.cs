using System;
using Volunteer.Core;
using Xunit;

namespace BuckeyeStore.Core.Tests
{
    public class ListingTests
    {
        [Fact]
        public void Test1()
        {
            var listing = new Listing
            {
                Id = 1,
                EventName = "Outreach",
                ProducerName = "United"              
            };

            //Assert
            Assert.NotNull(listing.Id);
            Assert.NotNull(listing.EventName);
            Assert.NotNull(listing.ProducerName);
            Assert.NotNull(listing.ExpireDate);
            Assert.NotNull(listing.eventTime);
        }
    }
}

