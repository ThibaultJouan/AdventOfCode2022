namespace AOC;

public class Jour6
{
    private List<string> Inputs { get; }
    
    public Jour6(List<string> inputs)
    {
        Inputs = inputs;
    }

    public int Resolve1()
    {
        for (var i = 0; i < Inputs[0].Length - 3; i++)
        {
            var test = Inputs[0].Substring(i, 4);
            var buffer = test.Distinct();
            if (buffer.Count() == 4)
            {
                return i + 4;
            }
        }
        return 0;
    }
    
    public int Resolve2()
    {
        for (var i = 0; i < Inputs[0].Length - 13; i++)
        {
            var test = Inputs[0].Substring(i, 14);
            var buffer = test.Distinct();
            if (buffer.Count() == 14)
            {
                return i + 14;
            }
        }
        return 0;
    }
}