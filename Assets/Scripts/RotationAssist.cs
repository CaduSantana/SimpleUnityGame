using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAssist : MonoBehaviour
{
    public Rigidbody myBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //System.Console.WriteLine("oi");
        if (myBody.gameObject.transform.up.y < 0.8)
        {
            //float intensity = myBody.gameObject.transform.up.y - 1;
            //Debug.Log(intensity);
            myBody.AddForce(Vector3.up /** intensity*/);
        }
    }
}
