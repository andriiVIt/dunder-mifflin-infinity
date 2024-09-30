using DataAccess.Models;

namespace Service;

public class GetPaperDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public bool Discontinued { get; set; }

    public static GetPaperDto FromEntity(Paper paper)
    {
        return new GetPaperDto
        {
            Id = paper.Id,
            Name = paper.Name,
            Price = paper.Price,
            Discontinued = paper.Discontinued
        };
    }

    public static Paper ToEntity(GetPaperDto getPaperDto)
    {
        return new Paper
        {
            Id = getPaperDto.Id,
            Name = getPaperDto.Name,
            Price = getPaperDto.Price,
            Discontinued = getPaperDto.Discontinued
        };
    }
}