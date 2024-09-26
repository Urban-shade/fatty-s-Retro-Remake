using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPM : MonoBehaviour
{
	public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S, jump = KeyCode.W;
	public float speed = 10, jumpHeight = 15;
	
	private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
	    _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
	    // Input.GetKey() is for HOLDING a key
	    // Input.GetKeydown() is for PRESSING a key
	    // Input.GetKeyup() is for RELEASING a key
	    
	    if(Input.GetKey(left))
	    {
	    	
	    	
	    }
    }
}
