using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * velocity, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.forward * velocity * -1, Space.Self);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //gameObject.transform.Translate(Vector3.left * velocity, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //gameObject.transform.Translate(Vector3.right * velocity, Space.Self);
        }
    }
}
