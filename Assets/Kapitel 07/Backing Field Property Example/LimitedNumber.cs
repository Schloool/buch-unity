public class LimitedNumber
{
    private int number;

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            if (value > 100)
            {
                value = 100;
            }
            
            number = value;
        }
    }

    public LimitedNumber(int number)
    { 
        Number = number;
    }
}