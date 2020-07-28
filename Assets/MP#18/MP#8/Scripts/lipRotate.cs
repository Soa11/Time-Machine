using UnityEngine;

public class lipRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0.2f, 0, Space.World);

        // Rotate the object around its local X axis at 1 degree per second
        // transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
        // transform.Rotate(Vector3.up * Time.deltaTime, Space.World);//
    }
}

