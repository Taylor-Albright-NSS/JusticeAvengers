using System.ComponentModel.DataAnnotations;
namespace JusticeAvengers.Models.DTOs;

public class HeroDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int HeroClassId { get; set; }
    public int Level { get; set; }
    public List<QuestDTO> Quest { get; set; }
    public List<EquipmentDTO> Equipment { get; set; }
    public HeroClassDTO HeroClass { get; set; }
}