using System.Collections;
using UnityEngine;

/// <summary>
/// Script für eine Waffe, die platziert werden kann, um nahegelegene Gegner anzugreifen.
/// </summary>
public class TowerWeapon : MonoBehaviour
{
    private TowerWeaponType weaponType;
    public bool Placed { get; set; }
    
    private TowerWaveHandler waveHandler;

    private void Awake()
    {
        waveHandler = FindObjectOfType<TowerWaveHandler>();
    }

    /// <summary>
    /// Beendet den Platzierungsvorgang der Waffe und schaltet sie für Angriffe "scharf".
    ///
    /// Dabei wird ein bestimmter Waffentyp gesetzt, anhand dessen sich das Angriffsverhalten ableitet.
    /// </summary>
    public void Deploy(TowerWeaponType weaponType)
    {
        this.weaponType = weaponType;
        StartCoroutine(ShootRoutine());
    }
    
    /// <summary>
    /// Coroutine für das Schießen dieser Waffe.
    ///
    /// Die Waffe schießt dabei in regelmäßigen Zeitabständen auf den nächstgelegenen Gegner.
    /// </summary>
    private IEnumerator ShootRoutine()
    {
        float nextShotTime = weaponType.shotInterval;
        while (true)
        {
            yield return null;

            TowerEnemy target = waveHandler.GetClosestEnemyToPoint(transform.position);
            if (target == null || 
                Vector3.Distance(target.transform.position, transform.position) > weaponType.range) continue;

            transform.LookAt(target.transform);
            
            nextShotTime -= Time.deltaTime;
            if (nextShotTime <= 0f)
            {
                target.Damage(weaponType.bulletDamage);
                nextShotTime += weaponType.shotInterval;
            }
        }
    }
}