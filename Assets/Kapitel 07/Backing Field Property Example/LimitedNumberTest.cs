using UnityEngine;

public class LimitedNumberTest : MonoBehaviour
{
    private void Start()
    {
        LimitedNumber a = new LimitedNumber(42);
        LimitedNumber b = new LimitedNumber(300);
        
        Debug.Log(a.Number);
        Debug.Log(b.Number);
    }
}