using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    private float fireTimer;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        fireTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
        if(fireTimer > 1)
        {
            Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation);
            fireTimer = 0;
        }
    }
}
