using UnityEngine;
using System.Collections;

public class rotCam : MonoBehaviour
{


    void Update()
    {

        transform.Rotate(0, Time.deltaTime*1f, 0, Space.World);
    }
}
