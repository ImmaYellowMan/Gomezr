using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemode : MonoBehaviour
{
    public static float timer = 60f;
    public Text timerSeconds;
    public Text scoreText;
    public Text playerName;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds.text = timer.ToString();
        scoreText.text = Fruit.score.ToString();
        playerName.text = PlayerWrite.N.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = "Time Left: " + timer.ToString("f2");
        scoreText.text = "Score: " + Fruit.score.ToString();
        //Debug.Log(Fruit.score);
        if (timer <= 0f)
        {
            Debug.Log("load Next SCENE");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
