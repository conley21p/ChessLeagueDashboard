
public class Tournament
{
    public uint contestantCount;
    public uint[] contestants;

    /*
        - The first index the round number
        - The second index will be game number and the value is the ID of the player that won
     */
    public uint[][] bracket;
}