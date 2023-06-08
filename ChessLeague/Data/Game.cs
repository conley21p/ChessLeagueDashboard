using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class Game
{
    public uint ID                  { get; set; }   = 0;
    public uint SeasonId            { get; set; }   = 0;
    public uint TournamentId        { get; set; }   = 0;
    public uint Light               { get; set; }   = 0;
    public uint Dark                { get; set; }   = 0;
    public uint State               { get; set; }   = 0;                // uint is the players ID
    public String PGN               { get; set; }   = "";
    public String Desc               { get; set; }   ="";
    public String TimePlayed         { get; set; }   = DateTime.UtcNow.AddHours(-5.00).ToString();
}
