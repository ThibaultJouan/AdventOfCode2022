namespace AOC;

public class Jour2
{
    public List<string> Inputs { get; }

    private const string Opponent = "ABC";
    private const string Me = "XYZ";
    private readonly int[,] table = {
        {
            3,6,0
        }, {
            0,3,6
        }, {
            6,0,3
        }
    };

    public Jour2(List<string> inputs)
    {
        Inputs = inputs;
    }

    public int Resolve1()
    {
        var result = 0;
        foreach (var l in Inputs)
        {
            result += table[Opponent.IndexOf(l[0]), Me.IndexOf(l[2])] + (Me.IndexOf(l[2]) + 1);
        }
        return result;
    }
}