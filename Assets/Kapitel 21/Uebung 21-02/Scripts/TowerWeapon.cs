using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class TowerWeapon : MonoBehaviour
{
    public TowerWeaponType WeaponType { get; set; }
    public bool Placed { get; set; }
    
    private TowerWaveHandler waveHandler;

    private void Awake()
    {
        waveHandler = FindObjectOfType<TowerWaveHandler>();
    }

    private void Start()
    {
        StartCoroutine(ShootRoutine());
    }

    private IEnumerator ShootRoutine()
    {
        float nextShotTime = WeaponType.shotFrequency;
        while (true)
        {
            if (!Placed || WeaponType == null)
            {
                yield return null;
                continue;
            }
            
            TowerEnemy target = waveHandler.ActiveEnemies
                .OrderBy(enemy => Vector3.Distance(enemy.transform.position, transform.position))
                .FirstOrDefault();
            nextShotTime -= Time.deltaTime;
            yield return null;

            if (target == null || 
                Vector3.Distance(target.transform.position, transform.position) > WeaponType.range) continue;

            transform.LookAt(target.transform);
            
            if (nextShotTime <= 0f)
            {
                target.Damage(WeaponType.bulletDamage);
                nextShotTime = WeaponType.shotFrequency;
            }
        }
    }
}