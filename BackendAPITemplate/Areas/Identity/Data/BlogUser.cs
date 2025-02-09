using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendAPITemplate.Models;
using Microsoft.AspNetCore.Identity;

namespace BackendAPITemplate.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BlogUser class
public class BlogUser : IdentityUser
{
    public virtual ICollection<DynamicContent> Posts { get; set; }
}

