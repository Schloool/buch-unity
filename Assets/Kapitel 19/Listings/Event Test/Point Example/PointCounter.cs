using System;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    public event Action<int> OnUpdatePoints;
    
    private int points;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            points++;
            OnUpdatePoints?.Invoke(points);
        }
    }
}