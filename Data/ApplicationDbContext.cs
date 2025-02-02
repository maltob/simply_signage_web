using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimplySignage.Components.Pages;

namespace SimplySignage.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Content> SignageContent {get;set;}
    public DbSet<Display> Displays {get;set;}
}
