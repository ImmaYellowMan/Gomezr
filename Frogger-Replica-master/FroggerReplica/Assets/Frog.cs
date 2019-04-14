using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public static int life = 3;
    public static int finalScore;

	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			
            if (life < 1)
            {
                finalScore = Score.CurrentScore;


                //StreamWriter sw = new StreamWriter("LeaderBoard.txt");
                using (StreamWriter sw = File.AppendText("LeaderBoard.txt"))
                {
                    sw.WriteLine(finalScore + ",");
                }



                Debug.Log("we lost the game ");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                life = 3;
                Score.CurrentScore = 0;
            }
            else
            {
                Debug.Log("WE LOST A Life!");
                life = life - 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
            
        }
	}
}
