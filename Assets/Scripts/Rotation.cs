using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensitivity = 3f;
    float mouseScroll = 0;

    // Update is called once per frame
    void Update()
    {
        mouseScroll = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(Vector3.up, mouseScroll);
    }
}
