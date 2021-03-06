﻿using HealthyPet.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyPet.Api
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        { }

        public ApplicationDBContext()
        {

        }

        public DbSet<Pet> Pets { get; set; }
    }
}
