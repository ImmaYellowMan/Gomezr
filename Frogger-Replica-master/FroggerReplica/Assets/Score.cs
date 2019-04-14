using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class Score : MonoBehaviour {

	public static int CurrentScore = 0;

	public Text scoreText;
    public Text lifeText;

	void Start ()
	{
        scoreText.text = CurrentScore.ToString();
        lifeText.text = Frog.life.ToString() ;
	}

}
