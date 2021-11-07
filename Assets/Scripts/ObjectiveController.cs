using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectiveController : MonoBehaviour
{
    private Text score;
    private void Start()
    {
        score = GameObject.FindWithTag("ScoreCounter").GetComponent<Text>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player") return; // Inimigos podem bater
        ScoreManager.points += 1;
        score.text = $"Score: {ScoreManager.points}/14";
        if (ScoreManager.points == 14)
        {
            score.text = "You Won! Press R to restart.";
            Time.timeScale = 0f;
        }
        Destroy(gameObject);
    }
}
