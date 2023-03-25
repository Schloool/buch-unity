public class PropertyBackingTest
{
    private string _attribute;

    public string Attribute
    {
        get => _attribute;
        private set => _attribute = value;
    }
}