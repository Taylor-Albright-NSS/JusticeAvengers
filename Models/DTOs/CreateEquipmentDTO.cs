

namespace JusticeAvengers.Models.DTOs;
public class CreateEquipmentDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int TypeId { get; set; }
    public decimal Weight { get; set; }
    public int HeroId { get; set; }
}