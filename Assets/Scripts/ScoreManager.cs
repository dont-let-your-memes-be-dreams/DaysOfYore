using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public int lives = 20;
	public int money = 100;

	public Text moneyCount;
	public Text livesCount;

	public void LoseLife(int l = 1) {
		lives -= l;
		if(lives <= 0) {
			GameOver();
		}
	}

	public void GameOver() {
		Debug.Log("Game Over");
		// TODO: Send the player to a game-over screen instead!
		SceneManager.LoadScene("GameOver");
	}

	void Update() {
		// FIXME: This doesn't actually need to update the text every frame.
		moneyCount.text = "Money: $" + money.ToString();
		livesCount.text = "Lives: "  + lives.ToString();


	}

}
