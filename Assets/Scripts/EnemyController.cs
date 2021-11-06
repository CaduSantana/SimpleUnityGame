using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject target;
    public float velocity = 0.001f;
    
    private void Start()
    {
        target = GameObject.FindWithTag("Player");    
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(target.transform);
        Vector3 step = target.transform.position - transform.position;
        transform.position += step * velocity;
    }
}
