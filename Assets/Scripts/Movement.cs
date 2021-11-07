using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float velocity = 0.003f;
    float veloTimer = 0;
    public Text spd;
    public Rigidbody myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody.centerOfMass = new Vector3(0, -0.9f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Enquanto W estiver apertado, aumenta velocidade
        if (Input.GetKey(KeyCode.W))
        {
            veloTimer += Time.deltaTime;
            if(veloTimer > 1 && velocity < 0.043)
            {
                veloTimer = 0;
                velocity += 0.005f;
            }
            gameObject.transform.Translate(Vector3.forward * velocity, Space.Self);
        }

        // Se soltou, tirar velocidade
        if (Input.GetKeyUp(KeyCode.W))
        {
            veloTimer = 0;
            velocity = 0.003f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.forward * -0.005f, Space.Self);
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
            ScoreManager.points = 0;
            Time.timeScale = 1;
        }

        spd.text = $"Speed: {(((int)(velocity * 10000)).ToString())}";
    }
}
