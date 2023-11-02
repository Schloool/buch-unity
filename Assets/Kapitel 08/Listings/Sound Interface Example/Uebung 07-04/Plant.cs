using UnityEngine;

public class Plant
{
    private string name;
    protected float averageHeightInCm;
    private float waterPerDay;

    public Plant(string name, float averageHeightInCm, float waterPerDay)
    {
        this.name = name;
        this.averageHeightInCm = averageHeightInCm;
        this.waterPerDay = waterPerDay;
    }

    public virtual void PrintData()
    {
        Debug.Log($"Name: {name}");
        Debug.Log($"Durchschnitts-Höhe: {averageHeightInCm} cm");
        Debug.Log($"Wasser Pro Tag: {waterPerDay} l");
    }
}