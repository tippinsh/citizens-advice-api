using CitizensAdvice.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CitizensAdvice.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<FeedbackForm> FeedbackForms { get; set; }
    public DbSet<ReferralForm> ReferralForms { get; set; }
}