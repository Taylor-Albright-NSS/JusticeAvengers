using JusticeAvengers.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using JusticeAvengers.Models.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddNpgsql<JusticeAvengersDbContext>(builder.Configuration["JusticeAvengersDbConnectionString"]);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// app.MapGet("/api/heroes/", (JusticeAvengersDbContext db) => 
// {
//     return db.Heroes
//     .Include(h => h.HeroClass)
//     .Select(h => new HeroDTO
//     {
//         Id = h.Id,
//         Name = h.Name,
//         QuestId = h.QuestId,
//         HeroClass = new HeroClassDTO
//         {
//             Id = h.HeroClass.Id,
//             Name = h.HeroClass.Name,
//         }
//     }).ToList();
// });

// app.MapGet("/api/heroes/{id}", (JusticeAvengersDbContext db, int id) => 
// {
//     Hero hero = db.Heroes
//     .Include(h => h.HeroClass)
//     .Include(h => h.Quest)
//     .Include(h => h.Equipment)
//     .Single(h => h.Id == id);
//     HeroDTO heroDTO = new HeroDTO
//     {
//         Id = hero.Id,
//         Name = hero.Name,
//         Description = hero.Description,
//         Level = hero.Level,
//         HeroClassId = hero.HeroClassId,
//         HeroClass = new HeroClassDTO
//         {
//             Id = hero.HeroClass.Id,
//             Name = hero.HeroClass.Name
//         },
//         QuestId = hero.QuestId,
//         Quest = new QuestDTO
//         {
//             Id = hero.Quest.Id,
//             Name = hero.Quest.Name
//         },
//         Equipment = hero.Equipment.Select(eq => new EquipmentDTO
//         {
//             Id = eq.Id,
//             Name = eq.Name
//         })
//         .ToList()
//     };
//     if (heroDTO == null) 
//     {
//         return Results.NotFound();
//     }
//     return Results.Ok(heroDTO);
// });

// app.MapGet("/api/equipment", (JusticeAvengersDbContext db) => 
// {
//     return db.Equipment
//     .Include(e => e.Type)
//     .Select(e => new EquipmentDTO 
//     {
//         Id = e.Id,
//         Name = e.Name,
//         Description = e.Description,
//         // TypeId = e.TypeId,
//         Type = new EquipmentTypeDTO
//         {
//             Id = e.Type.Id,
//             Name = e.Type.Name
//         }
//     });
// });

// app.MapGet("/api/quests", (JusticeAvengersDbContext db) => 
// {
//     return db.Quests
//     .Select(q => new QuestDTO 
//     {
//         Id = q.Id,
//         Name = q.Name,
//         IsCompleted = q.IsCompleted
//     });
// });

// app.MapGet("/api/quests/{id}", (JusticeAvengersDbContext db, int id) => 
// {
//     Quest quest = db.Quests
//     .Include(q => q.Heroes)
//     .Single(q => q.Id == id);

//     QuestDTO questDTO = new QuestDTO
//     {
//         Id = quest.Id,
//         Name = quest.Name,
//         Description = quest.Description,
//         IsCompleted = quest.IsCompleted,
//         Heroes = quest.Heroes.Select(hero => new HeroDTO 
//         {
//             Id = hero.Id,
//             Name = hero.Name

//         }).ToList()
//     };
//     return questDTO;
// });

// app.MapPost("/api/quests", (JusticeAvengersDbContext db, Quest quest) => 
// {
//     db.Quests.Add(quest);
//     db.SaveChanges();
//     return Results.Created($"/api/quests/{quest.Id}", quest);
// });

// app.MapPut("/api/heroes/{id}", (JusticeAvengersDbContext db, int id, int newQuestId) => 
// {
//     Hero hero = db.Heroes.FirstOrDefault(hero => hero.Id == id);
//     int? formerQuestId = hero.QuestId;
//     hero.QuestId = null;
//     hero.Quest = null;
//     db.SaveChanges();

//     hero.QuestId = newQuestId;
//     Quest quest = db.Quests.FirstOrDefault(quest => quest.Id == newQuestId);
//     hero.Quest = quest;
//     db.SaveChanges();
    
//     return Results.Ok($"{hero.Name} was changed successfully from {formerQuestId} to {hero.QuestId}");
// });

// app.MapPut("/api/equipment/{id}", (JusticeAvengersDbContext db, int id, int newHeroId) => 
// {
//     Equipment equipment = db.Equipment.FirstOrDefault(equipment => equipment.Id == id);
//     equipment.HeroId = newHeroId;
//     db.SaveChanges();

//     return Results.Ok($"Equipment with id {id} was assigned to a hero with id {newHeroId}");
// });

// app.MapPut("/api/quests/{id}", (JusticeAvengersDbContext db, int id) => 
// {
//     Quest quest = db.Quests.FirstOrDefault(quest => quest.Id == id);
//     quest.IsCompleted = true;
//     db.SaveChanges();
//     return Results.Ok($"Quest has been completed!!");
// });

// app.MapPost("/api/equipment", (JusticeAvengersDbContext db, CreateEquipmentDTO createEquipmentDTO) => 
// {
//     var equipmentType = db.EquipmentTypes.FirstOrDefault(eq => eq.Id == createEquipmentDTO.TypeId);
//     Equipment equipment = new Equipment
//     {
//         Name = createEquipmentDTO.Name,
//         Description = createEquipmentDTO.Description,
//         TypeId = createEquipmentDTO.TypeId,
//         Type = equipmentType,
//         Weight = createEquipmentDTO.Weight,
//         HeroId = createEquipmentDTO.HeroId,
//     };
//     db.Equipment.Add(equipment);
//     db.SaveChanges();
//     return Results.Ok(equipment.Id);
// });

// app.MapDelete("/api/equipment/{id}", (JusticeAvengersDbContext db, int id) => 
// {
//     Equipment equipment = db.Equipment.FirstOrDefault(e => e.Id == id);
//     db.Equipment.Remove(equipment);
//     db.SaveChanges();
//     return Results.NoContent();
// });

// app.MapDelete("/api/heroes/{id}", (JusticeAvengersDbContext db, int id) => 
// {

//     Hero hero = db.Heroes.FirstOrDefault(h => h.Id == id);
//     int? formerQuestId = hero.QuestId;
//     hero.QuestId = null;
//     db.SaveChanges();
//     return Results.Ok($"{hero.Name} {hero.Id} deleted, former quest id was {formerQuestId}");
// });

// app.MapDelete("/api/quests/{id}", (JusticeAvengersDbContext db, int id) => 
// {
//     Quest quest = db.Quests
//     .Include(q => q.Heroes)
//     .FirstOrDefault(q => q.Id == id);

//     foreach(var hero in quest.Heroes)
//     {
//         hero.QuestId = null;
//     }

//     db.Quests.Remove(quest);
//     db.SaveChanges();
//     return Results.Ok($"Quest with id {quest.Id} has been removed");
// });

app.MapGet("/api/heroes", (JusticeAvengersDbContext db) => 
{
    return db.Heroes.Select(h => new Hero 
    {
        Id = h.Id,
        Name = h.Name,
        Description = h.Description,
        HeroClassId = h.HeroClassId,
        Level = h.Level,
        Quest = h.Quest,
        Equipment = h.Equipment,
        HeroClass = h.HeroClass
    });
});


app.Run();

