﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;


namespace MonaWebApp.Models
{
    public class MonaContext : DbContext
    {
        public DbSet<SocialNetworks> SingleBlogs { get; set; }

    }
}