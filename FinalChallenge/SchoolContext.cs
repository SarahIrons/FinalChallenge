﻿using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace FinalChallenge
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
