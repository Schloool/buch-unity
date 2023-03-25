public class LimitedNumber
{
    private int _number;

    public int Number
    {
        get
        {
            return _number;
        }
        set
        {
            if (value > 100)
            {
                value = 100;
            }
            
            _number = value;
        }
    }

    public LimitedNumber(int number)
    { 
        Number = number;
    }
}