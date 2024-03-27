using System.Collections;
using UnityEngine;

/// <summary>
/// Script für die Waffe, mit welcher der Spieler durch das Klicken mit der Maus neue Kugeln schießt.
/// </summary>
public class ShooterGun : MonoBehaviour
{
    [SerializeField] private ShooterBullet bulletPrefab;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private float reloadDuration = 0.5f;

    private bool isReloading;

    private void Update()
    {
        if (!isReloading && Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    /// <summary>
    /// Schießt eine Kugel ab.
    ///
    /// Nach dem Abschießen wird automatisch das "Nachladen" gestartet, sodass der Spieler für eine vorgegebene Zeit
    /// nicht erneut schießen kann.
    /// </summary>
    private void Shoot()
    {
        Instantiate(bulletPrefab, spawnPosition.position, transform.rotation);
        StartCoroutine(ReloadRoutine());
    }

    /// <summary>
    /// Coroutine für das Nachladen der Waffe.
    ///
    /// Erst, nachdem das Nachladen beendet ist, kann erneut geschossen werden.
    /// </summary>
    private IEnumerator ReloadRoutine()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadDuration);
        isReloading = false;
    }
}