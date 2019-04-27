using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    public static float startForce = 10f;
    public static float gravity = .5f;

    

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
        rb.gravityScale = gravity;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


            Debug.Log("I've Hit a Bomb");
            Destroy(gameObject);
        }
    }

    
}
