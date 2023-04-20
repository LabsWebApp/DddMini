namespace DddMini.Ef;

public class MiniEventsDbContext : DbContext
{
    public DbSet<MiniEventDto> MiniEvents { get; set; } = null!;

    public MiniEventsDbContext(DbContextOptions options) : base(options) { }
}