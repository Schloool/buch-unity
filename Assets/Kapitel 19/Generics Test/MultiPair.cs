public class MultiPair<TFirst, TSecond>
{
    public TFirst First { get; set; }
    public TSecond Second { get; set; }

    public MultiPair(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }
}