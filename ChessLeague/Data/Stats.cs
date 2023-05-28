using System.Text.Json.Serialization;

public class Stats
{
    [JsonPropertyName("ID")]
    public uint Id { get; set; }

    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; }

    [JsonPropertyName("DeletedAt")]
    public object? DeletedAt { get; set; }

    [JsonPropertyName("SeasonId")]
    public uint? SeasonId { get; set; }

    [JsonPropertyName("PlayerId")]
    public uint? PlayerId { get; set; }

    [JsonPropertyName("Rating")]
    public uint? Rating { get; set; }

    [JsonPropertyName("Wins")]
    public uint? Wins { get; set; }

    [JsonPropertyName("Losses")]
    public uint? Losses { get; set; }

    [JsonPropertyName("Draws")]
    public uint? Draws { get; set; }

    [JsonPropertyName("HighestRating")]
    public uint? HighestRating { get; set; }
}