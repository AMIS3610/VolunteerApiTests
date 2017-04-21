using System;

namespace Volunteer.Core
{
    public class Account
    {
        public int Id{get; set;}
        public string UserName{get; set;}
        public string Password{get; set;}
        public string fName{get; set;}
        public string lName{get;set;}

        public Listing Listing {get; set;}

        public void AddListing(Listing listing)
        {
            this.Listing = listing;
        }
    }
}
