
using UnityEngine;
using UnityEngine.SceneManagement;


public class WordCollision : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
