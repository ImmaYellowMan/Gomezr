using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public static float startForce = 15f;
    public static float gravity = 1f;
   

    public static int score = 0; 

    public static float width = 1f, height = 1f, Length = 1f;

    Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
        rb.gravityScale = gravity;
        

    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);
            score = score + 10;
			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
			Destroy(gameObject);
		}
	}

    void Awake()
    {
        Vector3 scale = new Vector3(width, height, Length);
        transform.localScale = scale;
    }

    
}

