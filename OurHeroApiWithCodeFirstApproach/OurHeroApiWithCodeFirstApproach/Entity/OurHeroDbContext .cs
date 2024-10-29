﻿using Microsoft.EntityFrameworkCore;
using static OurHeroApiWithCodeFirstApproach.Model.OurHero;

public class OurHeroDbContext : DbContext
{
    public OurHeroDbContext(DbContextOptions<OurHeroDbContext> options) : base(options)
    {
    }
    // Registered DB Model in OurHeroDbContext file
    public DbSet<OurHeros> OurHeros { get; set; }

    /*
     OnModelCreating mainly used to configured our EF model
     And insert master data if required3 
    */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Setting a primary key in OurHero model
        modelBuilder.Entity<OurHeros>().HasKey(x => x.Id);

        // Inserting record in OurHero table
        modelBuilder.Entity<OurHeros>().HasData(
            new OurHeros
            {
                Id = 1,
                FirstName = "System",
                LastName = "",
                isActive = true,
            }
        );
    }
}