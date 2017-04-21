using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volunteer.Core;
using Volunteer.Api.Data;

namespace Volunteer.Api.Controllers
{
 [Route("api/myaccount")]     
 public class MyAccountController : Controller     
    {

            private readonly VolunteerContext db;
            
            public MyAccountController(VolunteerContext context) {
                this.db = context;
            }
            //Support for the root collection of accounts
            [HttpGet] 
            public IActionResult GetAccounts() 
                {  
                    return Ok(db.Accounts); 
                }    

            //Support for getting a single account by updating the Get Method    
            [HttpGet("{id}")]   
            public IActionResult Get(int id)   
                {    
                    return Ok(db.Accounts.Find(id));  
                } 

            public IActionResult Post([FromBody]Account account)
            {
                throw new NotImplementedException();
            }

            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody]Account account)
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