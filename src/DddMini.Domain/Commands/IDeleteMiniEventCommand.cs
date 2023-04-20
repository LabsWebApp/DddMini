namespace DddMini.Domain.Commands;

public interface IDeleteMiniEventCommand
{
    Task Execute(Guid id);
}