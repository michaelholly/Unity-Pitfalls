using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour
{
	public string scene;

	public void LoadScene()
	{
		SceneManager.LoadScene(scene);
	}
}
