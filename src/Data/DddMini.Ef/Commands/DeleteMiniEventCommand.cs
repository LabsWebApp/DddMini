namespace DddMini.Ef.Commands;

public class DeleteMiniEventCommand : CommandBase, IDeleteMiniEventCommand
{
    public DeleteMiniEventCommand(MiniEventsDbContextFactory contextFactory) 
        : base(contextFactory) { }

    public async Task Execute(Guid id)
    {
        await using var context = ContextFactory.Create();
        MiniEventDto miniEventDto = new()
        {
            Id = id,
        };

        context.MiniEvents.Remove(miniEventDto);
        await context.SaveChangesAsync();
    }
}