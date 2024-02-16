public class PersonData
{
    private string firstName;
    private string lastName;
    private float heightInMeters;
    private int age;
    
    public string Name() => $"{firstName} {lastName}";

    public float HeightInCentimeters => heightInMeters * 100f;

    public bool IsOfLegalAge() => age >= 18;

    public PersonData(string firstName, string lastName, float heightInMeters, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.heightInMeters = heightInMeters;
        this.age = age;
    }
}
