using DddMini.Domain.Models;

namespace DddMini.Domain.Commands;

public interface IUpdateMiniEventCommand
{
    Task Execute(MiniEvent miniEvent);
}