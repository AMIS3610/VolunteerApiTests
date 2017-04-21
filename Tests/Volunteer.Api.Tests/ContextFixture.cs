using System;
using System.Linq;
using Volunteer.Api.Data;
using Volunteer.Core;
using Microsoft.EntityFrameworkCore;

namespace Volunteer.Api.Tests
{
    public class ContextFixture : IDisposable
    {

        public ContextFixture()
        {
            InitializeContext();
        }

        public void Dispose()
        {
            Db = null;
        }

        public VolunteerContext Db { get; private set; }

        private void InitializeContext()
        {
            //This is a 'Global' Arrange. 
            var builder = new DbContextOptionsBuilder<VolunteerContext>()
                .UseInMemoryDatabase();

            var context = new VolunteerContext(builder.Options);

            var listings = Enumerable.Range(1, 10)
                .Select(i => new Listing { Id = i, EventName = $"Outreach{i}", ProducerName = "United" });

            context.Listings.AddRange(listings);

            int changed = context.SaveChanges();

            Db = context;
        }
    }
}