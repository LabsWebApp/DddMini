namespace DddMini.Ef
{
    public class MiniEventsDbContextFactory
    {
        private readonly DbContextOptions _options;

        public MiniEventsDbContextFactory(DbContextOptions options) => _options = options;

        public MiniEventsDbContext Create() => new(_options);
    }
}
