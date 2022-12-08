namespace AOC;

public class Jour8
{
    private List<string> Inputs { get; }
    private int MaxLength { get; }
    private int MaxHeight { get; }

    public Jour8(List<string> inputs)
    {
        Inputs = inputs;
        MaxLength = Inputs[0].Length;
        MaxHeight = Inputs.Count;
    }

    public int Resolve1()
    {
        var result = 0;
        for (var x = 0; x < MaxLength; x++)
        {
            for (var y = 0; y < MaxHeight; y++)
            {
                if (IsVisibleFromOutside(x, y))
                    result++;
            }
        }
        return result;
    }
    
    public int Resolve2()
    {
        var max = 0;
        
        for (var x = 0; x < MaxLength; x++)
        {
            for (var y = 0; y < MaxHeight; y++)
            {
                if (ScenicScore(x, y) > max)
                    max = ScenicScore(x, y);
            }
        }
        return max;
    }

    private int ScenicScore(int x, int y)
    {
        var treeHeight = int.Parse(Inputs[x][y].ToString());
        var up = 0;
        var down = 0;
        var left = 0;
        var right = 0;

        for (var i = x-1; i >= 0; --i)
        {
            if (int.Parse(Inputs[i][y].ToString()) < treeHeight && i != 0) continue;
            left = x-i;
            break;
        }
        for (var i = x+1; i < MaxLength; ++i)
        {
            if (int.Parse(Inputs[i][y].ToString()) < treeHeight && i != MaxLength - 1) continue;
            right = i-x;
            break;
        }
        for (var i = y-1; i >= 0; --i)
        {
            if (int.Parse(Inputs[x][i].ToString()) < treeHeight && i != 0) continue;
            up = y-i;
            break;
        }
        for (var i = y+1; i < MaxLength; ++i)
        {
            if (int.Parse(Inputs[x][i].ToString()) < treeHeight && i != MaxHeight - 1) continue;
            down = i-y;
            break;
        }
        return up * down * left * right;
    }

    private bool IsVisibleFromOutside(int x, int y)
    {
        var treeHeight = int.Parse(Inputs[x][y].ToString());
        var up = true;
        var down = true;
        var left = true;
        var right = true;

        for (var i = x-1; i >= 0; --i)
        {
            if (int.Parse(Inputs[i][y].ToString()) < treeHeight) continue;
            left = false;
            break;
        }
        for (var i = x+1; i < MaxLength; ++i)
        {
            if (int.Parse(Inputs[i][y].ToString()) < treeHeight) continue;
            right = false;
            break;
        }
        for (var i = y-1; i >= 0; --i)
        {
            if (int.Parse(Inputs[x][i].ToString()) < treeHeight) continue;
            up = false;
            break;
        }
        for (var i = y+1; i < MaxLength; ++i)
        {
            if (int.Parse(Inputs[x][i].ToString()) < treeHeight) continue;
            down = false;
            break;
        }
        return up || down || right || left;
    }
}