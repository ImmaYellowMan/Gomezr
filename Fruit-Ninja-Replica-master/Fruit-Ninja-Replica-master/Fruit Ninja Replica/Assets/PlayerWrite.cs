using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class PlayerWrite : MonoBehaviour
{
    public InputField playerName;
    public Text Name;
    public Text LeaderBoard;
    private static string path = "Assets/";
    public static string N;
    public string leaderBoardName;
    public string leaderBoardScore;
    //public string[] CompleatedLB;
    


    // Start is called before the first frame update
    public void GetInput(string name)
    {
        Name.text = name.ToString();
        N = name;


    }
    public void WriteScore()
    {
        using (StreamWriter sw = File.AppendText(path + "LeaderBoard.txt"))
        {
            sw.WriteLine(N + "," + Fruit.score);
            Fruit.score = 0;
        }

    }
    public void ReadLeaderBoard()
    {
        //TextAsset leaderboard = Resources.Load<TextAsset>("LeaderBoard");
        using (StreamReader sr = File.OpenText(path + "LeaderBoard.txt"))
        {
            string[] data = sr.ReadToEnd().Split('\n');
            //Debug.Log(data.Length);

            for (int i = 0; i < data.Length - 1; i++)
            {
                
                string[] row = data[i].Split(new char[] { ',' });
                leaderBoardName = row[0];
                leaderBoardScore = row[1];
                

                LeaderBoard.text += row[0].ToString() +" Score: "+ row[1].ToString() + '\n'; 
               
            }
        }

       
         


    }
}
