﻿using UnityEngine;

public class ClickerUpgrade : ScriptableObject
{
    public int costs;
    public string name;

    public int GetCostsForLevel(int level)
    {
        return costs * level * 2;
    }
}