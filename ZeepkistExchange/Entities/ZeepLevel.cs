namespace ZeepkistExchange.Entities;

public class ZeepLevel
{
    public int TotalVotes { get; set; } = 0;
    public int TotalPoints { get; set; } = 0;
    public ulong WorkshopId { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }


    public ZeepLevel(ulong workshopId, string name, string author, int totalVotes, int totalPoints)
    {
        WorkshopId = workshopId;
        Name = name;
        Author = author;
        TotalVotes = totalVotes;
        TotalPoints = totalPoints;
    }

    public override string ToString()
    {
        return $"{Name} by ${Author}";
    }
}