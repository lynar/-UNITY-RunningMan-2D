using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //to increment the score on the screen

public class GameControl : MonoBehaviour {

	public static GameControl instance; //pour eviter qu'il y ait plusieur Gamecontroller en meme temps
	public GameObject gameOverText;
	public Text scoreText; //score text to be displayed on the screen
	public bool gameOver = false;
	public float scrollSpeed = -1.5f; //vitesse du background qui bouge

	private int score = 0;

	// Use this for initialization
	void Awake () {
		///gestion du nombre de gameController en marche
		if (instance == null) {
			instance = this; //cree un GameController si il n'y en a pas
		} else if (instance != this) { //si il en existe un

			Destroy (gameObject); //detruit l'objet
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		//if gameover et que le joueur clic alors le jeu reprend
		if (gameOver == true && Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		
	}

	public void NinjaScore()
	{
		if (gameOver) {
			return;
		}
		score++;
		scoreText.text = "SCORE: " + score.ToString ();

	}

	public void NinjaDied()
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
