using UnityEngine;

public class Interactions : MonoBehaviour
{
	public FirstPersonMovement movement;
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