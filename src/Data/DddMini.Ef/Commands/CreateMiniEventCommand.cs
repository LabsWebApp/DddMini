namespace DddMini.Ef.Commands;

public class CreateMiniEventCommand : CommandBase, ICreateMiniEventCommand
{
    public CreateMiniEventCommand(MiniEventsDbContextFactory contextFactory)
        : base(contextFactory) { }

    public async Task Execute(MiniEvent miniEvent)
    {
        await using var context = ContextFactory.Create();
        var miniEventDto = MiniEventDto.ToDto(miniEvent)!;

        context.MiniEvents.Add(miniEventDto);
        await context.SaveChangesAsync();
    }
}