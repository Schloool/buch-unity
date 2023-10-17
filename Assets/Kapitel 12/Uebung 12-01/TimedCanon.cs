using System.Collections;
using UnityEngine;

public class TimedCanon : MonoBehaviour
{
    [SerializeField] private float shotFrequency;
    [SerializeField] private CanonBall canonBallPrefab;
    
    private IEnumerator Start()
    {
        while (true)
        {
            ShootBall();   
            yield return new WaitForSeconds(shotFrequency);
        }
    }

    private void ShootBall()
    {
        CanonBall newCanonBall = Instantiate(canonBallPrefab, transform.position, Quaternion.identity);
        newCanonBall.Direction = transform.forward;
            
        Destroy(newCanonBall.gameObject, 3f);
    }
}
