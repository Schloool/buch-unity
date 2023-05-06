using UnityEngine;

public class PointSaver : MonoBehaviour
{
    private const string PointKey = "Points";
    
    private int currentPoints;

    private void Start()
    {
        currentPoints = PlayerPrefs.GetInt(PointKey, 0);
        PrintPoints();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt(PointKey, ++currentPoints);
            PrintPoints();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currentPoints = 0;
            PlayerPrefs.DeleteKey(PointKey);
            Debug.Log("Punkte gelöscht.");
        }
    }

    private void PrintPoints()
    {
        Debug.Log($"Aktuelle Punktzahl: {currentPoints}");
    }
}