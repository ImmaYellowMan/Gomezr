using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

 
   // this grabs the words from the list of words, then it splits to words
    private static TextAsset Listofwords = Resources.Load<TextAsset>("Listofwords");

    public static string[] data = Listofwords.text.Split(new char[] { ',' });
    
    // FOR TESTING PURPOSES ONLY
    //private static string[] wordList = { "test", "testing", "testoroni" };

    public static string GetRandomWord()
     {
        int randomIndex = Random.Range(0, data.Length);
        string randomWord = data[randomIndex];

        return randomWord;
     }
    
}
