namespace DddMini.Domain.Commands.Queries;

public interface IGetMiniEventByIdQuery
{
    Task<MiniEvent?> Execute(Guid id); 
}