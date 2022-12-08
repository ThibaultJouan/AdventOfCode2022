namespace AOC;

public class Jour7
{
    private List<string> Inputs { get; }
    public Directory root { get; set; }

    public Jour7(List<string> inputs)
    {
        Inputs = inputs;
    }

    public int Resolve1()
    {
        Setup();

        return lessThan100000(root.Directories);
    }
    
    public int Resolve2()
    {
        var sizeMAx = 70000000;
        Setup();

        var freeSpace = sizeMAx - root.Size;
        var required = 30000000 - freeSpace;

        var list = GetFullList(root.Directories);

        var buffer = root;

        foreach (var d in list)
        {
            if (d.Size >= required && d.Size <= buffer.Size)
            {
                buffer = d;
            }
        }
        
        
        return buffer.Size;
    }

    public List<Directory> GetFullList(List<Directory> input)
    {
        for (var i = 0; i < input.Count; i++)
        {
            input.AddRange(input[i].Directories);
        }

        return input;
    }

    public int lessThan100000(List<Directory> input)
    {
        var result = 0;
        input = GetFullList(input);
        foreach (var d in input)
        {
            if(d.Size <= 100000)
                result += d.Size;
        }
        return result;
    }



    public void Setup()
    {
        Directory current = new Directory();
        
        foreach (var l in Inputs)
        {
            if (l.Contains("$ ls"))
            {
                continue;
            }
            
            if (l.Contains('$'))
            {
                if (l.Contains("cd /"))
                {
                    root = new Directory();
                    root.Name = "/";
                    root.Directories = new List<Directory>();
                    root.Files = new List<File>();
                    current = root;
                    continue;
                }
                    
                var splited = l.Split(" ");
                if (splited[2] == "..")
                {
                    current.Parent.Size += current.Size;
                    current = current.Parent;
                }
                else
                {
                    current = current.Directories.First(d => d.Name == splited[2]);
                    if (current.Files == null)
                        current.Files = new List<File>();
                    if (current.Directories == null)
                        current.Directories = new List<Directory>();
                }
            }
            else
            {
                var splited = l.Split(" ");
                if (splited[0] == "dir")
                {
                    current.Directories.Add(new Directory(splited[1], current));
                }
                else
                {
                    current.Files.Add(new File(splited[1], int.Parse(splited[0])));
                    current.Size += int.Parse(splited[0]);
                }
            }
        }

        root.Size = 0;
        
        foreach (var l in Inputs)
        {
            if (!l.Contains("$") && !l.Contains("dir"))
            {
                var splited = l.Split(" ");
                root.Size += int.Parse(splited[0]);
            }
        }

    }

    public class Directory
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public Directory Parent { get; set; }
        public List<Directory> Directories { get; set; }
        public List<File> Files { get; set; }

        public Directory(string name, Directory parent)
        {
            Name = name;
            Parent = parent;
        }

        public Directory()
        {
            
        }
    }

    public class File
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }
    }
}