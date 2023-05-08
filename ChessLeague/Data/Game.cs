
public class Game
{
    public uint SeasonId            { get; set; }   = 0;
    public uint TournamentId        { get; set; }   = 0;
    public uint Light               { get; set; }   = 0;
    public uint Dark                { get; set; }   = 0;
    public uint State               { get; set; }   = 0;                // uint is the players ID
    public String PGN               { get; set; }   = string.Empty;
    public String Desc               { get; set; }   = string.Empty;
    public String TimePlayed         { get; set; }   = string.Empty;

}
