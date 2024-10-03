using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncreseScoreOnCollision2 : MonoBehaviour
{
	public ScoreCounter2 score;
	
	public void OnTriggerEnter2D(Collider2D collission)
 {
 	score.currentScore++;
 	if(score.currentScore>6)
 	{
 		SceneManager.LoadScene(3);
 	}
 	collission.transform.position=Vector2.zero;
 }
}
