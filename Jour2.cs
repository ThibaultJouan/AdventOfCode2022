namespace AOC;

public class Jour2
{
    public List<string> Inputs { get; }

    private const string Opponent = "ABC";
    private const string Me = "XYZ";
    private readonly int[,] _table = {
        {
            3,6,0
        }, {
            0,3,6
        }, {
            6,0,3
        }
    };
    
    private readonly int[,] _table2 = {
        {
            3,4,8
        }, {
            1,5,9
        }, {
            2,6,7
        }
    };

    public Jour2(List<string> inputs)
    {
        Inputs = inputs;
    }

    public int Resolve1()
    {
        return Inputs.Sum(l => _table[Opponent.IndexOf(l[0]), Me.IndexOf(l[2])] + (Me.IndexOf(l[2]) + 1));
    }

    public int Resolve2()
    {
        return Inputs.Sum(l => _table2[Opponent.IndexOf(l[0]), Me.IndexOf(l[2])]);
    }
}