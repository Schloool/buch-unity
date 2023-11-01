using UnityEngine;

public class ShooterCamera : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    [SerializeField] private float maxVerticalRotation = 90f;

    private float rotationX;
    private float rotationY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationX = Mathf.Clamp(rotationX - mouseY, -maxVerticalRotation, maxVerticalRotation);
        rotationY += mouseX;

        transform.localRotation = Quaternion.Euler(new Vector3(rotationX, rotationY));
    }
}