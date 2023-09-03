public readonly struct CharacterData
{
    public string Name { get; }
    public int Level { get; }

    public CharacterData(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public override string ToString()
    {
        return $"{Name}, Level {Level}";
    }
}