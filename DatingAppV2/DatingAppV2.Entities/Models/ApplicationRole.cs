﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DatingAppV2.Entities.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole() : base()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }

        public ApplicationRole(string roleName, string description, DateTime creationDate) : base(roleName)
        {
            this.Description = description;
            this.CreationDate = creationDate;
        }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}