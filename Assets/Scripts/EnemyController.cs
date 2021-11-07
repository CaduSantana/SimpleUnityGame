using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    GameObject target;
    public float velocity = 0.001f;
    public int health = 200;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != 6) return;
        // Se colidiu com objeto da layer "tiro", rodar...  
        if (collision.gameObject.tag == "cannonball")
        {
            health -= 100;
        }
        else if (collision.gameObject.tag == "bullet")
        {
            health -= 10;
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}