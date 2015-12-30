﻿using MecWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MecWebApi.Context
{
    public class CoursesDbContext : DbContext
    {
        public CoursesDbContext()
            : base("Xyz")
        {
        }

        public DbSet<MECCourses> MECCourses { get; set; }
    }
}