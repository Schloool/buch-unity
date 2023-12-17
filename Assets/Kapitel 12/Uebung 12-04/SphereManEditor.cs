using UnityEngine;

public class SphereManEditor : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;
    [SerializeField] private GameObject sphereMan;

    public GameObject[] PlacedSpheres { get; private set; }
    
    private Camera camera;
    private int currentPlaceIndex;
    
    private void Awake()
    {
        camera = Camera.main;
        PlacedSpheres = new GameObject[5];
        currentPlaceIndex = 0;
    }

    private void Update()
    {
        if (currentPlaceIndex >= PlacedSpheres.Length) return;
        
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit)) return;

        GameObject newSphere = Instantiate(spherePrefab, hit.point, Quaternion.identity);
        PlacedSpheres[currentPlaceIndex++] = newSphere;

        if (currentPlaceIndex >= PlacedSpheres.Length)
        {
            sphereMan.SetActive(true);
        }
    }
}
