using System.Drawing;

namespace TaskManager.Entities;

public class Priority
{
    public string Name { get; private set; }
    public Color Color { get; private set; }

    public Priority(string name, Color color)
    {
        Name = name;
        Color = color;
    }

}