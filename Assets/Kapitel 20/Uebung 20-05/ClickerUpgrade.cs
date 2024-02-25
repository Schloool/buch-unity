using UnityEngine;

[CreateAssetMenu(menuName = "Clicker/Clicker Upgrade")]
public class ClickerUpgrade : ScriptableObject
{
    public int costs;
    public string name;
    public int pointsPerSecond;
    public int pointsPerClick;

    public int GetCostsForLevel(int level)
    {
        return costs * level;
    }
}