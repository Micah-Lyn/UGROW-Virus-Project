using UnityEngine;

public class Interactions : MonoBehaviour
{
	public FirstPersonMovement movement;
	//public class Random;
	  
	//int i = 1;
	void OnCollisionEnter(Collision col)
	{
		//var rand = new Random();
	//	int num = rand.Next(20 - i);
		if (col.collider.tag == "Infected")
		{
			//if (num < 5)
			//{
				// End the game
				// Stopping movement
				movement.enabled = false;
				FindObjectOfType<GameManagerS1>().EndGame();
			//}
			
			//i = i + 1;
		}
	}
}