namespace GameStore.Api.Dtos;

public record class GameDto(
    int id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate)
{   
    // transformando o preço em String o currency pt-br
    public string  PriceDisplay => Price == 0 ? "Gratuito" : Price.ToString("C");
}
