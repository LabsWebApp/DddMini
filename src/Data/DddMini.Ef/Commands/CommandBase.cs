namespace DddMini.Ef.Commands;

public abstract class CommandBase
{
    protected readonly MiniEventsDbContextFactory ContextFactory;

    protected CommandBase(MiniEventsDbContextFactory contextFactory)
        => ContextFactory = contextFactory;
}