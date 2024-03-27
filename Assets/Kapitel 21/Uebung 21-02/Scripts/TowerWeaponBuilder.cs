using System.Collections;
using UnityEngine;

/// <summary>
/// Script, das den Bauvorgang für eine Waffe vornimmt.
/// </summary>
public class TowerWeaponBuilder : MonoBehaviour
{
    [SerializeField] private GameObject weaponBuildPlane;
    [SerializeField] private TowerWeapon weaponPrefab;

    public TowerWeapon CurrentWeapon { get; private set; }
    
    private Camera camera;

    private void Awake()
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
    }

    /// <summary>
    /// Beginnt den Platzierungsvorgang, indem die Vorlage in der Scene erstellt wird und von da an dem Mauszeiger
    /// folgt.
    ///
    /// Der Platzierungsvorgang wird erst beim nächsten Mausklick abgeschlossen, nach welchem die Waffe aktiv wird.
    /// </summary>
    public IEnumerator StartPlacement(TowerWeaponType weaponType)
    {
        CurrentWeapon = Instantiate(weaponPrefab, weaponBuildPlane.transform.position, Quaternion.identity);
        Instantiate(weaponType.model, CurrentWeapon.transform);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        CurrentWeapon.Deploy(weaponType);
        CurrentWeapon.Placed = true;
        CurrentWeapon = null;
    }
}