using TMPro;
using UnityEngine;

/// <summary>
/// Script für die Anzeige der aktuellen Welle.
/// </summary>
public class TowerWaveDisplay : MonoBehaviour
{
    private TMP_Text text;
    private TowerWaveHandler waveHandler;
    
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        waveHandler = FindObjectOfType<TowerWaveHandler>();
        waveHandler.OnChangeWave += HandleChangeWave;
    }

    private void Start()
    {
        HandleChangeWave(waveHandler.CurrentWave);
    }

    private void OnDestroy()
    {
        waveHandler.OnChangeWave -= HandleChangeWave;
    }

    /// <summary>
    /// Behandelt das Wechseln auf eine neue Welle, indem die neue Zahl als Textelement dargestellt wird.
    /// </summary>
    private void HandleChangeWave(int wave)
    {
        text.text = wave.ToString();
    }
}