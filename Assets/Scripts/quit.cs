using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour {

	// Use this for initialization
	public void quitapplication()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }
}
