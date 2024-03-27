using UnityEngine;

/// <summary>
/// Script für einen Diamanten, der vom Spieler eingesammelt werden kann.
/// </summary>
public class PlatformDiamond : MonoBehaviour
{
    public void HandleCollection()
    {
        Destroy(gameObject);
    }
}