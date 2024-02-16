public class Calculator
{
    // Nicht-statisches Beispiel:
    // private int a;
    // private int b;
    //
    // public Calculator(int a, int b)
    // {
    //     this.a = a;
    //     this.b = b;
    // }
    //
    // public int AddAndDouble()
    // {
    //     return (a + b) * 2;
    // }

    public static int AddAndDouble(int a, int b)
    {
        return (a + b) * 2;
    }       
}