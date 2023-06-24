using TMPro;
using UnityEngine;

public class TextChangeTest : MonoBehaviour
{
    [SerializeField] private TMP_Text myText;
    [SerializeField] private string newText;

    private void Start()
    {
        myText.text = newText;
    }
}
