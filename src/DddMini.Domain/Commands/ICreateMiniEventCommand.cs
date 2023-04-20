using DddMini.Domain.Models;

namespace DddMini.Domain.Commands;

public interface ICreateMiniEventCommand
{
    Task Execute(MiniEvent miniEvent);
}