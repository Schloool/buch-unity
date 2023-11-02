public class AbstractComponentImplementation : MyAbstractComponent
{
    public int intAttribute;
    
    public override string DoSomething()
    {
        return "Hallo aus der Kindklasse!";
    }
}