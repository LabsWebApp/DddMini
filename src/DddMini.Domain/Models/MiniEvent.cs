namespace DddMini.Domain.Models;

public class MiniEvent
{
    public Guid Id { get; }
    public string Name { get; }
    public DateTime Date { get; }
    public bool IsMandatory { get; }
    public byte[]? Image { get; }

    public MiniEvent(Guid id, string name, DateTime date, bool isMandatory, byte[]? image)
    {
        Id = id;
        Name = name;
        Date = date;
        IsMandatory = isMandatory;
        Image = image;
    }
}