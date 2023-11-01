using TMPro;
using UnityEngine;

public class TowerWaveDisplay : MonoBehaviour
{
    private TMP_Text text;
    private TowerWaveHandler waveHandler;
    
    private void Start()
    {
        text = GetComponent<TMP_Text>();
        waveHandler = FindObjectOfType<TowerWaveHandler>();
        waveHandler.OnChangeWave += HandleChangeWave;
    }

    private void OnDestroy()
    {
        waveHandler.OnChangeWave -= HandleChangeWave;
    }

    private void HandleChangeWave(int wave)
    {
        text.text = wave.ToString();
    }
}