using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volunteer.Core;
using Volunteer.Api.Data;

namespace Volunteer.Api.Controllers
{
 [Route("api/listings")]     
 public class ListingsController : Controller     
    {

            private readonly VolunteerContext db;
            
            public ListingsController(VolunteerContext context) {
                this.db = context;
            }
            //Support for the root collection of Listings
            [HttpGet] 
            public IActionResult GetListings() 
                {  
                    return Ok(db.Listings); 
                }    

            //Support for getting a single listing by updating the Get Method    
            [HttpGet("{id}")]   
            public IActionResult Get(int id)   
                {    
                    return Ok(db.Listings.Find(id));  
                } 

            public IActionResult Post([FromBody]Listing listing)
            {
                throw new NotImplementedException();
            }

            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody]Listing listing)
            {
                throw new NotImplementedException();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                throw new NotImplementedException();
            }
    } 
}