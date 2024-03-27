using UnityEngine;

/// <summary>
/// Dieses Script realisiert die Bewegung des Hintergrunds, der sich hinter dem Flugzeug befindet.
/// Dafür wird das Objekt dauerhaft nach links bewegt und, sobald es eine festgelegte Koordinate unterschreitet, wieder
/// auf eine Ausgangsposition zurückgesetzt.
///
/// Indem dieses Script an zwei Hintergrund-Objekte gehangen wird, entsteht ein Scroll-Effekt ohne Unterbrechung und es
/// wirkt dauerhaft so, als würde das Flugzeug nach rechts fliegen.
/// </summary>
public class FlappyBackground : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private float resetCoordinate;

    private void Update()
    {
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        if (transform.position.x <= -resetCoordinate)
        {
            transform.position = new Vector3(resetCoordinate, transform.position.y);
        }
    }
}