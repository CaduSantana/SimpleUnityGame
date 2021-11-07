using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectiveController : MonoBehaviour
{
    private Text score;
    private Text winTxt;
    private void Start()
    {
        score = GameObject.FindWithTag("ScoreCounter").GetComponent<Text>();
        winTxt = GameObject.FindWithTag("wintxt").GetComponent<Text>();
        winTxt.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player") return; // Inimigos podem bater
        ScoreManager.points += 1;
        score.text = $"Score: {ScoreManager.points}/14";
        Destroy(gameObject);
        if(ScoreManager.points == 14)
        {
            winTxt.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
