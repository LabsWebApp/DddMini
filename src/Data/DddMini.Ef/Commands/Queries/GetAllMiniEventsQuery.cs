using DddMini.Domain.Commands.Queries;

namespace DddMini.Ef.Commands.Queries;

public class GetAllMiniEventsQuery : CommandBase, IGetAllMiniEventsQuery
{
    public GetAllMiniEventsQuery(MiniEventsDbContextFactory contextFactory) 
        : base(contextFactory) { }

    public async Task<IEnumerable<MiniEvent>> Execute()
    {
        await using var context = ContextFactory.Create();
        return await context
            .MiniEvents
            .Select(e => MiniEventDto.ToMiniEvent(e)!)
            .ToListAsync();
    }
}