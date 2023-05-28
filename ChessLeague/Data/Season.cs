
public class Season
{
    public uint ID { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; } = null;
    public string Name { get; set; } = "";
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; } = DateTime.UtcNow;
    public int TournamentId { get; set; } = 0;

}
public class SeasonCreate
{
    public string Name { get; set; } = "";
    public string? StartDate { get; set; }
    public string? EndDate { get; set; } 

}
