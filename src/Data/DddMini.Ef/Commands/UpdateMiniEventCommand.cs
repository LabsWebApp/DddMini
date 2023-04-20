namespace DddMini.Ef.Commands;

public class UpdateMiniEventCommand:CommandBase, IUpdateMiniEventCommand
{
    public UpdateMiniEventCommand(MiniEventsDbContextFactory contextFactory) 
        : base(contextFactory) { }

    public async Task Execute(MiniEvent miniEvent)
    {
        await using var context = ContextFactory.Create();
        var miniEventDto = MiniEventDto.ToDto(miniEvent);

        context.MiniEvents.Update(miniEventDto!);
        await context.SaveChangesAsync();
    }
}