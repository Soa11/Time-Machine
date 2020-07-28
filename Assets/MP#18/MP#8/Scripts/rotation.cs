using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        // Rotate the object around its local Y axis at 1 degree per second
        transform.Rotate(Time.deltaTime, 0, 0);

       
    }
}