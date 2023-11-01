using UnityEngine;

public class TowerWeaponBuilder : MonoBehaviour
{
    [SerializeField] private GameObject weaponBuildPlane;
    [SerializeField] private TowerWeapon weaponPrefab;

    public TowerWeapon CurrentWeapon { get; private set; }
    
    private Camera camera;

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        if (CurrentWeapon == null) return;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit) && hit.collider.gameObject == weaponBuildPlane)
        {
            CurrentWeapon.transform.position = hit.point;
        }

        if (Input.GetMouseButtonDown(0))
        {
            CurrentWeapon.Placed = true;
            CurrentWeapon = null;
        }
    }

    public void StartPlacement(TowerWeaponType weaponType)
    {
        CurrentWeapon = Instantiate(weaponPrefab, weaponBuildPlane.transform.position, Quaternion.identity);
        Instantiate(weaponType.model, CurrentWeapon.transform);
        CurrentWeapon.WeaponType = weaponType;
    }
}