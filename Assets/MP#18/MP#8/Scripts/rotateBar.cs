using UnityEngine;

public class rotateBar : MonoBehaviour
{
    void Update()
    {
        // Rotate the object around its local Y axis at 1 degree per second
       // transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0.05f, 0));
        // ...also rotate around the World's Y axis
        // transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
    }
}