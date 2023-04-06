using System;

public class Table
{
    private readonly int legs;
    private readonly string name;

    public Table(int legs)
    {
        this.legs = legs;
    }

    public override string ToString()
    {
        return $"Tisch mit {legs} Beinen";
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Table table)) return false;

        return legs == table.legs;
    }

    protected bool Equals(Table other)
    {
        return legs == other.legs && name == other.name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(legs, name, name);
    }
}