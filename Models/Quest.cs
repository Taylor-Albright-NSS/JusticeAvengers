using System.ComponentModel.DataAnnotations;
namespace JusticeAvengers.Models;

public class Quest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public List<Hero> Heroes { get; set; }
}