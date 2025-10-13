using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simple.CRM.WebApp.Data.Models;

namespace Simple.CRM.WebApp.Data;

public class ApplicationDbContext : IdentityDbContext<Agent>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<VacationPackage> VacationPackages { get; set; } = null!;
    public DbSet<Booking> Bookings { get; set; } = null!;
}
