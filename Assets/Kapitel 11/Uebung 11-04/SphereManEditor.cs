using UnityEngine;

public class SphereManEditor : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;
    [SerializeField] private GameObject sphereMan;

    public GameObject[] placedSpheres;
    
    private Camera camera;
    private int currentPlaceIndex;
    
    private void Awake()
    {
        camera = Camera.main;
        placedSpheres = new GameObject[5];
        currentPlaceIndex = 0;
    }

    private void Update()
    {
        if (currentPlaceIndex >= placedSpheres.Length) return;
        
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit)) return;

        GameObject newSphere = Instantiate(spherePrefab, hit.point, Quaternion.identity);
        placedSpheres[currentPlaceIndex] = newSphere;
        currentPlaceIndex++;

        if (currentPlaceIndex >= placedSpheres.Length)
        {
            sphereMan.SetActive(true);
        }
    }
}
