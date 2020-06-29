using UnityEngine;

public class Interactions : MonoBehaviour
{
	public FirstPersonMovement movement;
	public GameManagerS1 gameManager;
	
	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "Infected")
		{
			// End the game
			// Stopping movement
			movement.enabled = false;
		}
	}
}