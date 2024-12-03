using System.ComponentModel.DataAnnotations;
namespace JusticeAvengers.Models.DTOs;

public class QuestDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public List<HeroDTO> Heroes { get; set; }
}