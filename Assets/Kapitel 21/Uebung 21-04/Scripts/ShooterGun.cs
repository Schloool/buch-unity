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
        if (!isReloading && Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, spawnPosition.position, transform.rotation);
        StartCoroutine(ReloadRoutine());
    }

    private IEnumerator ReloadRoutine()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadDuration);
        isReloading = false;
    }
}