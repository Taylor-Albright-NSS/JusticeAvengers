using Microsoft.EntityFrameworkCore;
using JusticeAvengers.Models;

public class JusticeAvengersDbContext : DbContext
{

    public DbSet<Equipment> Equipment { get; set; }
    public DbSet<EquipmentType> EquipmentTypes { get; set; }
    public DbSet<Hero> Heroes { get; set; }
    public DbSet<HeroClass> HeroClasses { get; set; }
    public DbSet<Quest> Quests { get; set; } 

    public JusticeAvengersDbContext(DbContextOptions<JusticeAvengersDbContext> context) : base(context)
    {

    }

protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         
        modelBuilder.Entity<Hero>().HasData(
        new Hero { Id = 1, Name = "Aragorn", Description = "A skilled ranger and warrior", HeroClassId = 1, Level = 20},
        new Hero { Id = 2, Name = "Legolas", Description = "An elven archer with unmatched precision", HeroClassId = 2, Level = 18},
        new Hero { Id = 3, Name = "Gandalf", Description = "A wise and powerful wizard", HeroClassId = 3, Level = 25},
        new Hero { Id = 4, Name = "Frodo", Description = "A brave halfling on a dangerous journey", HeroClassId = 4, Level = 10},
        new Hero { Id = 5, Name = "Eowyn", Description = "A fierce shieldmaiden of Rohan", HeroClassId = 5, Level = 15},
        new Hero { Id = 6, Name = "Boromir", Description = "A noble warrior with a strong sense of duty", HeroClassId = 1, Level = 17},
        new Hero { Id = 7, Name = "Gimli", Description = "A stout and fearless dwarf warrior", HeroClassId = 6, Level = 16},
        new Hero { Id = 8, Name = "Thranduil", Description = "A king of the woodland elves", HeroClassId = 2, Level = 22},
        new Hero { Id = 9, Name = "Arwen", Description = "A graceful elf skilled in healing and magic", HeroClassId = 3, Level = 14},
        new Hero { Id = 10, Name = "Samwise", Description = "A loyal companion with unwavering courage", HeroClassId = 4, Level = 12}
        );

        modelBuilder.Entity<Quest>().HasData(
        new Quest { Id = 1, Name = "Defeat the Orcs", Description = "Eliminate the orc horde threatening the kingdom", IsCompleted = false },
        new Quest { Id = 2, Name = "Rescue the Elf", Description = "Save the captured elf from the goblin cave", IsCompleted = false },
        new Quest { Id = 3, Name = "Retrieve the Amulet", Description = "Find the ancient amulet lost in the haunted forest", IsCompleted = false },
        new Quest { Id = 4, Name = "Defend the Castle", Description = "Protect the castle from the siege of the dark army", IsCompleted = true },
        new Quest { Id = 5, Name = "Explore the Ruins", Description = "Uncover the secrets of the ancient ruins", IsCompleted = false }
        );

        modelBuilder.Entity<HeroClass>().HasData(
        new HeroClass { Id = 1, Name = "Warrior" },
        new HeroClass { Id = 2, Name = "Archer" },
        new HeroClass { Id = 3, Name = "Wizard" },
        new HeroClass { Id = 4, Name = "Halfling" },
        new HeroClass { Id = 5, Name = "Shieldmaiden" },
        new HeroClass { Id = 6, Name = "Dwarf" }
        );

        modelBuilder.Entity<Equipment>().HasData(
        new Equipment { Id = 1, Name = "Sword of Valor", Description = "A blade imbued with the essence of courage", TypeId = 1, Weight = 12.5m, HeroId = 1 },
        new Equipment { Id = 2, Name = "Elven Bow", Description = "A bow crafted by the finest elven craftsmen", TypeId = 2, Weight = 4.3m, HeroId = 2 },
        new Equipment { Id = 3, Name = "Wizard's Staff", Description = "A staff that channels arcane power", TypeId = 3, Weight = 8.1m, HeroId = 3 },
        new Equipment { Id = 4, Name = "Shield of Light", Description = "A shield that radiates divine protection", TypeId = 4, Weight = 15.7m, HeroId = 5 },
        new Equipment { Id = 5, Name = "Dwarven Axe", Description = "A heavy axe forged in the mountain halls", TypeId = 5, Weight = 20.2m, HeroId = 7 },
        new Equipment { Id = 6, Name = "Ring of Stealth", Description = "A magical ring that grants invisibility", TypeId = 6, Weight = 0.2m, HeroId = 4 },
        new Equipment { Id = 7, Name = "Bow of Thranduil", Description = "The personal weapon of the woodland king", TypeId = 2, Weight = 3.9m, HeroId = 8 },
        new Equipment { Id = 8, Name = "Potion of Healing", Description = "Restores health when consumed", TypeId = 7, Weight = 0.5m, HeroId = 9 },
        new Equipment { Id = 9, Name = "Golden Dagger", Description = "A ceremonial weapon with a razor-sharp edge", TypeId = 1, Weight = 2.3m, HeroId = 10 },
        new Equipment { Id = 10, Name = "Amulet of Strength", Description = "Grants increased physical power", TypeId = 6, Weight = 1.1m, HeroId = 1 }
        );

        modelBuilder.Entity<EquipmentType>().HasData(
        new EquipmentType { Id = 1, Name = "Sword" },
        new EquipmentType { Id = 2, Name = "Bow" },
        new EquipmentType { Id = 3, Name = "Staff" },
        new EquipmentType { Id = 4, Name = "Shield" },
        new EquipmentType { Id = 5, Name = "Axe" },
        new EquipmentType { Id = 6, Name = "Accessory" },
        new EquipmentType { Id = 7, Name = "Potion" }
        );
    }
}