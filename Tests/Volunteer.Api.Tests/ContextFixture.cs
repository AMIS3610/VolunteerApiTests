using System;
using System.Linq;
using Volunteer.Api.Data;
using Volunteer.Core;
using Microsoft.EntityFrameworkCore;

namespace BuckeyeStore.Api.Tests
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

            var products = Enumerable.Range(1, 10)
                .Select(i => new Listing { Id = i, Name = $"T-Shirt{i}", Brand = "Nike" });

            context.Listings.AddRange(products);

            int changed = context.SaveChanges();

            Db = context;
        }
    }
}