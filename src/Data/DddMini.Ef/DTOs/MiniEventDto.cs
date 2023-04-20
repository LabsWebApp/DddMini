namespace DddMini.Ef.DTOs;

public class MiniEventDto
{
    public Guid Id { get; init; }
    public string Name { get; set; } = null!;
    public DateTime Date { get; set; }
    public bool IsMandatory { get; set; }

    public static MiniEvent? ToMiniEvent(MiniEventDto?  dto) => dto is null ? null
        : new MiniEvent(dto.Id, dto.Name, dto.Date, dto.IsMandatory, null);

    public static MiniEventDto? ToDto(MiniEvent? miniEvent) => miniEvent is null ? null
        : new MiniEventDto
        {
            Id = miniEvent.Id,
            Name = miniEvent.Name,
            Date = miniEvent.Date,
            IsMandatory = miniEvent.IsMandatory
        };
}