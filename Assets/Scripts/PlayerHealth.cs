using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int health;
    public Text hpCounter;
    public Text deathMsg;
    // Start is called before the first frame update
    void Start()
    {
        health = 150;
        deathMsg.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != 8) return;
        health -= 5;
        hpCounter.text = $"Health: {health}";

        if(health <= 0)
        {
            Time.timeScale = 0f;
            deathMsg.gameObject.SetActive(true);
        }
    }
}
