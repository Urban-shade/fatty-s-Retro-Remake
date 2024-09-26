using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreseScoreOnCollision : MonoBehaviour
{
	public ScoreCounter score;
	
	
	public void OnTriggerEnter2D(Collider2D collission)
 {
 	score.currentScore++;
 	collission.transform.position=Vector2.zero;
 	
 }
}
