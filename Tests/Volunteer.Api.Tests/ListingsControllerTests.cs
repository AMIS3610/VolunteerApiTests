using System;
using Xunit;
using Volunteer.Api.Controllers;
using Volunteer.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Volunteer.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace Volunteer.Api.Tests
{
    public class ListingsControllerTests : IClassFixture<ContextFixture>
    {

        private ContextFixture fixture;

        public ListingsControllerTests(ContextFixture contextFixture)
        {
            fixture = contextFixture;
        }

        [Fact]
        public void CanGetAllListings()
        {
            //Arrange
            var controller = new ListingsController(fixture.Db);

            //Act
            var result = controller.GetListings() as OkObjectResult;

            //Assert
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void CanGetProduct()
        {
            //Arrange
            var controller = new ListingsController(fixture.Db);

            //Act
            var result = controller.Get(1) as OkObjectResult;

            //Assert
            Assert.IsType<OkObjectResult>(result);

        }
    }
}