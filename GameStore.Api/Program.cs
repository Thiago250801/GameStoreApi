using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<GameDto> games = [
     new (1, "EA 24", "Sports", 259.00M, new DateOnly(2028,09,29)),
     new (2, "Resident Evil 4 Remake", "Action, Adventure", 169.00M, new DateOnly(2023,03,23)),
     new (3, "Counter Strike 2","FPS", 00M, new DateOnly(2024,01,15)),
     new (4, "EA 24", "Sports", 255.23M, new DateOnly(2024,01,15)),
];

app.MapGet("games", () => games);

app.MapGet("/", () => "Hello World!");

app.Run();
