namespace Builder.Models;

public class Engine
{
    public Engine(string name, string type, string instructions)
    {
        Name = name;
        Type = type;
        Instructions = instructions;
    }

    public string Name { get; }
    public string Type { get; }
    public string Instructions { get; }
}