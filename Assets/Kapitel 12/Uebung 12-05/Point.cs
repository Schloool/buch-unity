using System;
using UnityEngine;

public class Point
{
    private readonly float x;
    private readonly float y;
    private readonly string name;

    public Point(float x, float y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public override string ToString()
    {
        return $"{name}: ({x}, {y})";
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Point point)) return false;

        return Mathf.Approximately(point.x, x) && Mathf.Approximately(point.y, y);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y);
    }
}