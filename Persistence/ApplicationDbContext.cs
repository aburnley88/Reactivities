using Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Persistence;

public class ApplicationDbContext  : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
    {

    }

    public DbSet<Activity> Activities { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>().HasData(
            new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Past Activity 1",
                Date = DateTime.UtcNow.AddMonths(-3),
                Category = "Drinks",
                Description = "Activity 3 months ago",
                Venue = "U st",
                City = "Washington D.C."
            },
            new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Future Activity 1",
                Date = DateTime.UtcNow.AddMonths(2),
                Description = "Activity 1, 2 months in the future",
                Category = "Dating",
                Venue = "Armiturworks",
                City = "Tampa"
            },
            new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Past Activity 2",
                Date = DateTime.UtcNow.AddMonths(-2),
                Description = "Activity 2, 2 months ago",
                Category = "Festive",
                City = "Atlanta",
                Venue = "YSL HQ"
            },
            new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Future Activity 2",
                Date = DateTime.UtcNow.AddMonths(2),
                Category = "Social",
                Description = "Activity 2, 2 months in future",
                City = "Shirlington",
                Venue = "Pallette22"
            },
            new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Future Activity 3",
                Date = DateTime.UtcNow.AddMonths(4),
                Category = "Sports",
                Description = "Activity 3, 4 months in future",
                City = "San Diego",
                Venue = "Aztecs Stadium"
            },
            new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Past Activity 3",
                Date = DateTime.UtcNow.AddMonths(-5),
                Category = "Dating",
                Description = "Activity 2, 5 months ago",
                City = "Los Angeles",
                Venue = "Staples Center"
            },
            new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Future Activity 4",
                Date = DateTime.UtcNow.AddDays(2),
                Category = "Social",
                Description = "Activity 4, 2 days in future",
                City = "Arlington",
                Venue = "UpaDidi"
            });

    }
}
