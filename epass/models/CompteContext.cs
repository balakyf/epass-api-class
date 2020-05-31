﻿using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class CompteContext: DbContext
    {
        public CompteContext(DbContextOptions<CompteContext> options)
            : base(options)
        {
        }

        public DbSet<Compte> Comptes { get; set; }
    }
}
