using UnityEngine;

public class LimitedNumberTest : MonoBehaviour
{
    private void Start()
    {
        LimitedNumber a = new LimitedNumber();
        a.Number = 42;
        LimitedNumber b = new LimitedNumber();
        b.Number = 300;
        
        Debug.Log(a.Number);
        Debug.Log(b.Number);
    }
}