using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncreseScoreOnCollision : MonoBehaviour
{
	public ScoreCounter score;
	
	
	public void OnTriggerEnter2D(Collider2D collission)
 {
 	score.currentScore++;
 	if(score.currentScore>6)
 	{
 		SceneManager.LoadScene(2);
 	}
 	collission.transform.position=Vector2.zero;
 	
 }
}
