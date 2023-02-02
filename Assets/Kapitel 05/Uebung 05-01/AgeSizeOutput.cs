using UnityEngine;

public class AgeSizeOutput : MonoBehaviour
{
    public int sizeInCm;
    public int age;
    
    void Start()
    {
        Debug.Log("Es folgt die Körpergröße in cm und das Alter:");
        Debug.Log(sizeInCm);
        Debug.Log(age);
    }
}
