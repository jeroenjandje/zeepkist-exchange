namespace ZeepkistExchange.classes;

public class ZeepLevel
{
    public int TotalVotes { get; } = 0;
    public int TotalPoints { get; } = 0;

    public ZeepLevel(int totalVotes, int totalPoints)
    {
        TotalVotes = totalVotes;
        TotalPoints = totalPoints;
    }
}