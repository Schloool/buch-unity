using UnityEngine;

public class Dwarf : MonoBehaviour
{
    [Header("Generelle Daten")]
    
    [SerializeField]
    [Tooltip("Der Name dieses Zwergs.")]
    private string name;
    
    [SerializeField] 
    [Tooltip("Die Beschreibung dieses Zwergs.")]
    [TextArea(4, 7)]
    private string description;

    [Space(30f)]
    [Header("Einstellungen für das Spiel")]
    
    [SerializeField]
    [Tooltip("Die Angriffskraft dieses Zwergs.")]
    [Range(0, 100)]
    private float attackPower;

    [SerializeField] 
    [Tooltip("Die Anzahl der Lebenspunkte dieses Zwergs.")]
    [Min(10)]
    private int healthPoints;
}
