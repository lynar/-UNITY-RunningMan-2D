using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplePool : MonoBehaviour {

	public int TemplePoolSize = 5;
	public GameObject TemplePrefab;
	public float spawnRate =3f;
	public float templeMin = -1f;
	public float templeMax = 3.5f;

	private GameObject[] temples;
	private Vector2 objectPoolPosition = new Vector2(-15f, -45f);
	private float timeSinceLastSpawned;
	private float spawnYPosition = 0f;
	private int currentTemple = 0;

	// Use this for initialization
	void Start () {
		temples = new GameObject[TemplePoolSize];
		for (int i = 0; i < TemplePoolSize; i++) {
			temples [i] = (GameObject)Instantiate (TemplePrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawned += Time.deltaTime;
		if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) {
			timeSinceLastSpawned = 0;
			float spawnXPosition = Random.Range (templeMin, templeMax);
			temples [currentTemple].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
			currentTemple++;
			if (currentTemple >= TemplePoolSize) {
				currentTemple = 0;
			}
		}
	}
}
