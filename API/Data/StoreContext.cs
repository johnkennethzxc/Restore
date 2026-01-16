using System;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Basket> Baskets { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole { Id = "bb6d65cd-252b-4ed6-8fa3-19db4f434000", Name = "Member", NormalizedName = "MEMBER"},
                new IdentityRole { Id = "bd801f29-8bfa-42d3-8121-dda97150f288", Name = "Admin", NormalizedName = "ADMIN"}
            );
    }
}