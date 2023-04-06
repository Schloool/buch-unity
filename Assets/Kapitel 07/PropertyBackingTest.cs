public class PropertyBackingTest
{
    private string attribute;

    public string Attribute
    {
        get => attribute;
        private set => attribute = value;
    }
}