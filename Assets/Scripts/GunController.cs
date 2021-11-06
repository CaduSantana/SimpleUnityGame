using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float fireRate = 1;
    float fireTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
        if(Input.GetMouseButton(0) && (fireTimer > fireRate))
        {
            fireTimer = 0;
            Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
