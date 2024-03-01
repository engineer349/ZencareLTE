﻿using Microsoft.EntityFrameworkCore;
using ZencareLTE.Models;

namespace ZencareLTE.Data
{
    public class ApplicationDbContext : DbContext
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<AppointmentDetails> AppointmentDetails { get; set; }
        public DbSet<PrescriptionDetails> PrescriptionDetails { get; set; }
        public DbSet<BedRegistrationDetails> BedRegistrationDetails { get; set; }
    }


}
