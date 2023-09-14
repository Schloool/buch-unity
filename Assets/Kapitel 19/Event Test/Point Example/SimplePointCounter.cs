using TMPro;
using UnityEngine;

public class SimplePointCounter : MonoBehaviour
{
    private TMP_Text pointText;
    private int points;

    private void Start()
    {
        pointText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            points++;
            pointText.text = points.ToString();
        }
    }
}
