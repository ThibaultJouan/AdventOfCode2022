using System.Net.Security;

namespace AOC;

public class Jour3
{
    private List<string> Inputs { get; }
    private const string Priorities = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public Jour3(List<string> inputs)
    {
        Inputs = inputs;
    }

    public int Resolve1()
    {
        var result = 0;

        foreach (var l in Inputs)
        {
            var common = String.Empty;
            var part1 = l.Substring(0, l.Length / 2);
            var part2 = l.Substring(l.Length / 2);
            common = part1.Where(c => part2.Contains(c)).Aggregate(common, (current, c) => current + c);
            result += common.Distinct().Sum(c => Priorities.IndexOf(c));
        }

        return result;
    }

    public int Resolve2()
    {
        var result = 0;
        var lines = new string[3];

        for (var i = 0; i < Inputs.Count; i++)
        {
            lines[i % 3] = Inputs[i];

            if (i % 3 != 2) 
                continue;
            
            var buffer = string.Empty;
            var common = string.Empty;
            
            common = lines[0].Distinct().Where(c => lines[1].Distinct().Contains(c))
                .Aggregate(buffer, (current, c) => current + c).Where(c => lines[2].Distinct().Contains(c))
                .Aggregate(common, (current, c) => current + c);
            
            result += common.Distinct().Sum(c => Priorities.IndexOf(c));
        }
        return result;
    }
}