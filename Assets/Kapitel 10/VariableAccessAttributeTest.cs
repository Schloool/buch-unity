using UnityEngine;

public class VariableAccessAttributeTest : MonoBehaviour
{
    // [SerializeField] 
    // private string myString;
    
    [HideInInspector] 
    public string myString;
}