using UnityEngine;

public class EnumOutputTest : MonoBehaviour
{
    private void Start()
    {
        ChessFigure myFigure = (ChessFigure) 3;
        Debug.Log(myFigure.ToString());
        Debug.Log((int) myFigure);
        
        Debug.Log((ChessFigure) 5);
    }
}