using UnityEngine;

public class Tree : Plant
{
    private float stemDiameter;

    public Tree(string name, float averageHeightInCm, float waterPerDay, float stemDiameter) 
        : base(name, averageHeightInCm, waterPerDay)
    {
        this.stemDiameter = stemDiameter;
    }

    public override void PrintData()
    {
        base.PrintData();
        Debug.Log($"Durchmesser Stamm: {stemDiameter} cm");
    }

    public float CalculateStemVolume()
    {
        return stemDiameter * stemDiameter * averageHeightInCm;
    }
}