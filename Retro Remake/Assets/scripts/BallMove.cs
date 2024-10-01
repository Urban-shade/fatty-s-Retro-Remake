using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
	public Rigidbody2D rb;
	public float startingSpeed;

	
    // Start is called before the first frame update
    void Start()
    {
	    bool isRight = UnityEngine.Random.value >= 0.5;
	    
	    float xVelocity = -1f; 
	    
	    if (isRight == true)
	    {
	    	xVelocity = 1f;
	    }
	    
	    
	    float yVelocity = UnityEngine.Random.Range(3, 2);
	    float yVelocity2 = UnityEngine.Random.Range(-3, 2);
	    
	    
	    rb.velocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }

    // Update is called once per frame
    void Update()
	{
		
		if (transform.position == new Vector3 (0, 0))
		{
			bool isRight = UnityEngine.Random.value >= 0.5;
	    
			float xVelocity = -1f; 
	    
			if (isRight == true)
			{
				xVelocity = 1f;
			}
	    
	    
			float yVelocity = UnityEngine.Random.Range(-2, 2);
	    
	    
			rb.velocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
		}
    }
}
