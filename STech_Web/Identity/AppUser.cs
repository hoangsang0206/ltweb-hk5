﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNet.Identity.EntityFramework;
using STech_Web.Models;

namespace STech_Web.Identity
{
    public class AppUser : IdentityUser
    {
        public string UserFullName { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string Address { get; set; }
    }
}