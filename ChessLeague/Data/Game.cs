
public class Game
{
    public uint Player1         { get; set; }   = 0;
    public uint Player2         { get; set; }   = 0;
    public uint Winner          { get; set; }   = 0;                // uint is the players ID
    public bool Draw            { get; set; }   = false;
    public String PGN           { get; set; }   = string.Empty;

}
