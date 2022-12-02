namespace AOC;

public class Jour1
{
    public List<string> Inputs { get; }
    
    public Jour1(List<string> inputs)
    {
        Inputs = inputs;
    }

    public int Resolve1()
    {
        var elfs = new List<int>();
        var elf = 0;

        foreach (var l in Inputs)
        {
            if (!string.IsNullOrEmpty(l))
            {
                elf += int.Parse(l);
                continue;
            }
            elfs.Add(elf);
            elf = 0;
        }
        return elfs.Max();
    }
    
    public int Resolve2()
    {
        var elfs = new List<int>();
        var elf = 0;

        foreach (var l in Inputs)
        {
            if (!string.IsNullOrEmpty(l))
            {
                elf += int.Parse(l);
                continue;
            }
            elfs.Add(elf);
            elf = 0;
        }

        elfs.Sort();
        elfs.Reverse();

        return elfs[0] + elfs[1] + elfs[2];
    }
}