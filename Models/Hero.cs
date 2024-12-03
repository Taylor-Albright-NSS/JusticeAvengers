using System.ComponentModel.DataAnnotations;
namespace JusticeAvengers.Models;

public class Hero 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int HeroClassId { get; set; }
    public int Level { get; set; }
    public List<Quest> Quest { get; set; }
    public List<Equipment> Equipment { get; set; }
    public HeroClass HeroClass { get; set; }
}