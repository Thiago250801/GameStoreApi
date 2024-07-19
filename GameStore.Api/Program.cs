using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<GameDto> games = [
     new (1, "EA 24", "Sports", 259.00M, new DateOnly(2023,09,29)),
     new (2, "Resident Evil 4 Remake", "Ação, Aventura", 169.00M, new DateOnly(2023,03,23)),
     new (3, "Counter Strike 2","FPS", 00M, new DateOnly(2012,08,21)),
     new (4, "Red Dead Redemption 2", "Ação, Aventura", 98.96M, new DateOnly(2019,12,05)),
];

app.MapGet("games", () => games);

app.MapGet("/", () => "Hello World!");

app.Run();
