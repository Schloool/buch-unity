using UnityEngine;

public class TextToNumber : MonoBehaviour
{
    private void Start()
    {
        int x = int.Parse("32");
        Debug.Log(x + 10);

        float y = float.Parse("42.5");
        Debug.Log(y + 2f);
    }
}