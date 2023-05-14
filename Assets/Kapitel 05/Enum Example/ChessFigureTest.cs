using UnityEngine;

public class ChessFigureTest : MonoBehaviour
{
    public ChessFigure chessFigure;

    private void Start()
    {
        if (chessFigure == ChessFigure.King)
        {
            Debug.Log("Der König wurde ausgewählt!");
        }
    }
}