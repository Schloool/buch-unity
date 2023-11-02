using UnityEngine;

public class FindAllComponentsTest : MonoBehaviour
{
    private void Start()
    {
        Transform[] transforms = FindObjectsOfType<Transform>();
        Debug.Log($"{transforms.Length} Game Objects gefunden.");

        foreach (Transform transform in transforms)
        {
            transform.position = new Vector3(1f, 1f, 1f);
        }
    }
}