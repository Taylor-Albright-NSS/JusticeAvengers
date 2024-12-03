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


app.MapGet("/api/heroes/", (JusticeAvengersDbContext db) => 
{
    return db.Heroes
    .Include(h => h.HeroClass)
    .Select(h => new HeroDTO
    {
        Id = h.Id,
        Name = h.Name,
        HeroClass = new HeroClassDTO
        {
            Id = h.HeroClass.Id,
            Name = h.HeroClass.Name,
        }
    }).ToList();
});

app.MapGet("/api/heroes/{id}", (JusticeAvengersDbContext db, int id) => 
{
    Hero hero = db.Heroes
    .Include(h => h.HeroClass)
    .Include(h => h.Quest)
    .Include(h => h.Equipment)
    .SingleOrDefault(h => h.Id == id);

    HeroDTO heroDTO = new HeroDTO
    {
        Id = hero.Id,
        Name = hero.Name,
        Description = hero.Description,
        HeroClassId = hero.HeroClassId,
        Level = hero.Level,
        HeroClass = new HeroClassDTO
        {
            Id = hero.HeroClass.Id,
            Name = hero.HeroClass.Name
        },
        Quest = hero.Quest == null ? null : new QuestDTO // Check if Quest is null
        {
            Id = hero.Quest.Id,
            Name = hero.Quest.Name

        },
        Equipment = hero.Equipment.Select(eq => new EquipmentDTO
        {
            Id = eq.Id,
            Name = eq.Name
        })
        .ToList()

    };
    if (heroDTO == null) 
    {
        return Results.NotFound();
    }
    return Results.Ok(heroDTO);
});

app.Run();

