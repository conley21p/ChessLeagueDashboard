using System.Text.Json.Serialization;

public class Player
{
    [JsonPropertyName("ID")]
    public uint Id { get; set; }

    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("UpdatedAt")]
    public string? UpdatedAt { get; set; }

    [JsonPropertyName("DeletedAt")]
    public string? DeletedAt { get; set; }

    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    // Constructor
    // public Player(uint id, string? createdAt, string? updatedAt, string? deletedAt, string? name)
    // {
    //     Id = id;
    //     CreatedAt = createdAt;
    //     UpdatedAt = updatedAt;
    //     DeletedAt = deletedAt;
    //     Name = name;
    // }
}