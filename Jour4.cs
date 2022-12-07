namespace AOC;

public class Jour4
{
    private List<string> Inputs { get; }

    public Jour4(List<string> inputs)
    {
        Inputs = inputs;
    }

    public int Resolve1()
    {
        return (from l in Inputs
            select l.Split(",")
            into parts
            let part1 = parts[0].Split("-")
            let part2 = parts[1].Split("-")
            where int.Parse(part1[0]) <= int.Parse(part2[0]) && int.Parse(part1[1]) >= int.Parse(part2[1]) ||
                  int.Parse(part1[0]) >= int.Parse(part2[0]) && int.Parse(part1[1]) <= int.Parse(part2[1])
            select part1).Count();
    }

    public int Resolve2()
    {
        return (from l in Inputs
            select l.Split(",")
            into parts
            let part1 = parts[0].Split("-")
            let part2 = parts[1].Split("-")
            where int.Parse(part1[0]) <= int.Parse(part2[0]) && int.Parse(part1[1]) >= int.Parse(part2[1]) ||
                  int.Parse(part1[0]) >= int.Parse(part2[0]) && int.Parse(part1[1]) <= int.Parse(part2[1]) ||
                  int.Parse(part1[0]) <= int.Parse(part2[0]) && int.Parse(part1[1]) <= int.Parse(part2[1]) && int.Parse(part1[1]) >= int.Parse(part2[0]) || 
                  int.Parse(part1[0]) >= int.Parse(part2[0]) && int.Parse(part1[1]) >= int.Parse(part2[1]) && int.Parse(part1[0]) <= int.Parse(part2[1])
            select part1).Count();
    }
}