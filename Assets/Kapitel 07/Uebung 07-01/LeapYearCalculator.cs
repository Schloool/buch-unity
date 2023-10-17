using UnityEngine;

public class LeapYearCalculator : MonoBehaviour
{
    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            int randomYear = Random.Range(0, 2025);
            string isLeapYearText = IsLeapYear(randomYear) ? "ein" : "kein";
            Debug.Log($"{randomYear} ist {isLeapYearText} Schaltjahr");
        }
    }

    private bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}
