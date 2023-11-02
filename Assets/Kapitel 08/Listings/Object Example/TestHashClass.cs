using System;

public class TestHashClass
{
    private readonly int a;
    private readonly string b;
    private readonly bool c;

    public override int GetHashCode()
    {
        return HashCode.Combine(a, b, c);
    }
}