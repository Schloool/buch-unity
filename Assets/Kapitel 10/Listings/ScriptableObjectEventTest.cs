using UnityEngine;

[CreateAssetMenu(menuName = "Object/Event Test")]
public class ScriptableObjectEventTest : ScriptableObject
{
    public string variable;
    
    private void Awake()
    {
        Debug.Log("Awake");  
    }
    
    private void OnEnable()
    {
      Debug.Log("OnEnable");  
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");  
    }

    private void OnValidate()
    {
        Debug.Log("OnValidate");  
    }

    private void Reset()
    {
        Debug.Log("Reset");  
    }
    
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");  
    }
}