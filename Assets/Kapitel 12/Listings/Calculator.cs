public class Calculator
{
    public static int AddNumbers(string expression)
    {
        string[] numbers = expression.Split("+");
        return int.Parse(numbers[0]) + int.Parse(numbers[1]);
    }       
}