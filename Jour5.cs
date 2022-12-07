namespace AOC;

public class Jour5
{
    private List<string> Inputs { get; }
    private List<char>[] Crates { get; set; }

    public Jour5(List<string> inputs)
    {
        Inputs = inputs;
    }

    public string Resolve1()
    {
        var result = string.Empty;
        var index = Index();
        Crates = new List<char>[index];
        InitArray();
        StartingPosition();

        foreach (var instructions in from l in Inputs where l.Contains("move") select SplitInstructions(l))
        {
            for (var i = 0; i < instructions[0]; i++)
            {
                Crates[instructions[2]].Add(Crates[instructions[1]].Last());
                Crates[instructions[1]].RemoveAt(Crates[instructions[1]].Count-1);
            }
        }
        return Crates.Aggregate(result, (current, c) => current + c.Last());
    }
    
    public string Resolve2()
    {
        var result = string.Empty;
        var index = Index();
        Crates = new List<char>[index];
        InitArray();
        StartingPosition();

        foreach (var instructions in from l in Inputs where l.Contains("move") select SplitInstructions(l))
        {
            Crates[instructions[2]].AddRange(Crates[instructions[1]].GetRange(Crates[instructions[1]].Count-instructions[0], instructions[0]));
            Crates[instructions[1]].RemoveRange(Crates[instructions[1]].Count-instructions[0], instructions[0]);
        }
        return Crates.Aggregate(result, (current, c) => current + c.Last());
    }

    private int Index()
    {
        var index = Inputs.TakeWhile(l => l != "").Count()-1;
        var size = Inputs[index].Trim().Split(" ");
        return int.Parse(size[^1]);
    }

    private static int[] SplitInstructions(string line)
    {
        var instructions = new int[3];
        var splited = line.Split(" ");

        instructions[0] = int.Parse(splited[1]);
        instructions[1] = int.Parse(splited[3])-1;
        instructions[2] = int.Parse(splited[5])-1;
        
        return instructions;
    }

    private void InitArray()
    {
        for (var i = 0; i < Crates.Length; i++)
        {
            Crates[i] = new List<char>();
        }
    }

    private void StartingPosition()
    {
        var index = Inputs.TakeWhile(l => l != "").Count()-2;
        var position = 1;
        const int step = 4;

        foreach (var c in Crates)
        {
            for (var i = index; i >= 0; i--)
            {
                if(Inputs[i][position] != ' ')
                    c.Add(Inputs[i][position]);
            }
            position += step;
        }
    }
}