using TMPro;
using UnityEngine;

/// <summary>
/// Script für die Anzeige der bisher eingesammelten Diamanten.
/// </summary>
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

    /// <summary>
    /// Behandelt das Einsammeln eines neuen Diamantens, indem die bisher gesammelte Anzahl im Text aktualisiert wird.
    /// </summary>
    private void HandleCollectDiamond(int diamonds)
    {
        text.text = $"{diamonds} / {diamondCollector.AllDiamondCount}";
    }
}