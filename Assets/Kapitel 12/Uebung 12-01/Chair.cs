public class Chair
{
    public int legAmount;
    public float heightInMeters;
    public float sitLengthInCm;

    public float CalculateSitArea()
    {
        return sitLengthInCm * sitLengthInCm;
    }
}