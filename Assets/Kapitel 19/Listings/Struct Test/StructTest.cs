using UnityEngine;

public class StructTest : MonoBehaviour
{
    private CharacterData noData;
    
    private void Start()
    {
        CharacterData baldur = new CharacterData("Baldur", 75);
        Debug.Log(baldur.ToString());

        Debug.Log(noData.ToString());
    }
}