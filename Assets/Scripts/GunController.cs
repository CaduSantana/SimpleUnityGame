using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject cannonPrefab, submchPrefab, gunObj;
    private GameObject projectilePrefab;
    private float fireRate;
    float fireTimer;
    // Start is called before the first frame update
    void Start()
    {
        gunObj.transform.GetChild(1).gameObject.SetActive(false);
        gunObj.transform.GetChild(0).gameObject.SetActive(true);
        projectilePrefab = submchPrefab;
        fireRate = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        // Seleciona metralhadora
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gunObj.transform.GetChild(1).gameObject.SetActive(false);
            gunObj.transform.GetChild(0).gameObject.SetActive(true);
            projectilePrefab = submchPrefab;
            fireRate = 0.1f;
        }

        // Seleciona canhão
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gunObj.transform.GetChild(0).gameObject.SetActive(false);
            gunObj.transform.GetChild(1).gameObject.SetActive(true);
            projectilePrefab = cannonPrefab;
            fireRate = 1;
        }

        fireTimer += Time.deltaTime;
        if(Input.GetMouseButton(0) && (fireTimer > fireRate))
        {
            fireTimer = 0;
            Instantiate(projectilePrefab, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
