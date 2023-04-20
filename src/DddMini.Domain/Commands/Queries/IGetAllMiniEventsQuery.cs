namespace DddMini.Domain.Commands.Queries;

public interface IGetAllMiniEventsQuery
{
    Task<IEnumerable<MiniEvent>> Execute();
}