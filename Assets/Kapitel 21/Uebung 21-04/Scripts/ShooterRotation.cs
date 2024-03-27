using UnityEngine;

/// <summary>
/// Script für die Rotationsbewegung, mit der sich der Spieler durch das Bewegen der Maus drehen und das Fadenkreuz auf
/// Ziele ausrichten kann.
///
/// Die Rotation nach oben hin wird dabei durch einen Maximalwinkel limitiert.
/// </summary>
public class ShooterRotation : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    [SerializeField] private float maxVerticalRotation = 90f;

    private ShooterTimer timer;
    private float rotationX;
    private float rotationY;

    private void Awake()
    {
        timer = FindObjectOfType<ShooterTimer>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (timer.HasFinished)
        {
            Cursor.lockState = CursorLockMode.None;
            Destroy(this);
        }
        
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationX = Mathf.Clamp(rotationX - mouseY, -maxVerticalRotation, maxVerticalRotation);
        rotationY += mouseX;

        transform.localRotation = Quaternion.Euler(new Vector3(rotationX, rotationY));
    }
}