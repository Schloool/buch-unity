using TMPro;
using UnityEngine;

public class PlatformDiamondDisplay : MonoBehaviour
{
    private TMP_Text text;
    private PlatformDiamondCollector diamondCollector;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        diamondCollector = FindObjectOfType<PlatformDiamondCollector>();
        diamondCollector.OnCollectDiamond += HandleCollectDiamond;
    }

    private void Start()
    {
        HandleCollectDiamond(0);
    }

    private void HandleCollectDiamond(int diamonds)
    {
        text.text = $"{diamonds} / {diamondCollector.AllDiamondCount}";
    }
}