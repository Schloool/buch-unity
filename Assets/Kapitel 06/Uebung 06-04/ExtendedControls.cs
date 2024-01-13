using UnityEngine;

public class ExtendedControls : MonoBehaviour
{
    public float speed;
    
    private void Update()
    {
        float x = 0;
        float y = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 1;
        } 
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -1;
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            y = 1;
        } 
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            y = -1;
        }

        transform.position += new Vector3(x, 0f, y) * speed * Time.deltaTime;
    }
}
