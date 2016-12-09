using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour {

	// Use this for initialization
	public void creditsscene()
    {
        SceneManager.LoadScene("Credits");
    }
    public void titlescreen()
    {
        SceneManager.LoadScene("Title");
    }
    public void gameoversceen()
    {
        SceneManager.LoadScene("GameOver");
    }
}
