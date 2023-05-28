using System.Text.Json.Serialization;
public class PlayerStats
{
    [JsonPropertyName("Player")]
    public Player? Player { get; set; }

    [JsonPropertyName("Stats")]
    public Stats? Stats { get; set; }
}