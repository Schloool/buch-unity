using UnityEngine;

public class PointSaver : MonoBehaviour
{
    private const string pointKey = "Points";
    private int currentPoints;

    private void Awake()
    {
        currentPoints = PlayerPrefs.GetInt(pointKey, 0);
    }

    private void Start()
    {
        PrintPoints();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentPoints++;
            PlayerPrefs.SetInt(pointKey, currentPoints);
            PrintPoints();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currentPoints = 0;
            PlayerPrefs.DeleteKey(pointKey);
            Debug.Log("Punkte gelöscht.");
        }
    }

    private void PrintPoints()
    {
        Debug.Log($"Aktuelle Punktzahl: {currentPoints}");
    }
}