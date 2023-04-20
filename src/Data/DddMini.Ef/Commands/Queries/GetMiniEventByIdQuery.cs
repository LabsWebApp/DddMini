using DddMini.Domain.Commands.Queries;

namespace DddMini.Ef.Commands.Queries;

public class GetMiniEventByIdQuery : CommandBase, IGetMiniEventByIdQuery
{
    public GetMiniEventByIdQuery(MiniEventsDbContextFactory contextFactory) 
        : base(contextFactory) { }

    public async Task<MiniEvent?> Execute(Guid id)
    {
        await using var context = ContextFactory.Create();
        return MiniEventDto.ToMiniEvent(await context
            .MiniEvents
            .FirstOrDefaultAsync(e=>e.Id==id));
    }
}