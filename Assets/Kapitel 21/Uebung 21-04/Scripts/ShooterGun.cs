using System.Collections;
using UnityEngine;

public class ShooterGun : MonoBehaviour
{
    [SerializeField] private ShooterBullet bulletPrefab;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private float reloadDuration = 0.5f;

    private bool isReloading;

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        if (isReloading) return;
        
        ShooterBullet bullet = Instantiate(bulletPrefab, spawnPosition.position, Quaternion.identity);
        bullet.Direction = transform.forward;
        bullet.transform.forward = transform.forward;

        StartCoroutine(ReloadRoutine());
    }

    private IEnumerator ReloadRoutine()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadDuration);
        isReloading = false;
    }
}