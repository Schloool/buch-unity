using TMPro;
using UnityEngine;

public class ClickerStatsDisplay : MonoBehaviour
{
   [SerializeField] private TMP_Text currentPointsText;
   [SerializeField] private TMP_Text pointPerClickText;
   [SerializeField] private TMP_Text pointPerSecondText;
   
   private ClickerGameHandler gameHandler;

   private void Awake()
   {
      gameHandler = FindObjectOfType<ClickerGameHandler>();
      gameHandler.OnChangePoints += HandlePointsChange;
      gameHandler.OnChangeUpgrades += HandleUpgradesChange;
   }

   private void OnDestroy()
   {
      gameHandler.OnChangePoints -= HandlePointsChange;
      gameHandler.OnChangeUpgrades -= HandleUpgradesChange;
   }

   private void HandlePointsChange(int points)
   {
      currentPointsText.text = $"Punkte: {points}";
   }
   

   private void HandleUpgradesChange()
   {
      pointPerClickText.text = $"Punkte pro Klick: {gameHandler.GetPointsPerClick()}";
      pointPerSecondText.text = $"Punkte pro Sekunde: {gameHandler.GetPointsPerSecond()}";
   }
}