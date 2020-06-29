
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerS1 : MonoBehaviour
{
	
    public void EndGame()
	{
		Restart();
	}
	
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
