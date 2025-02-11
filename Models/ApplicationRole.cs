﻿using Microsoft.AspNetCore.Identity;

namespace BookWebAPI.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
            
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
