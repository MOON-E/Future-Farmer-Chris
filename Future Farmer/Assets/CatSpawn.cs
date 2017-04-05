using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawn : MonoBehaviour {
	// public variables
	/*
	public float secondsBetweenSpawning = 0.1f;
	public float xMinRange = -25.0f;
	public float xMaxRange = 25.0f;
	public float yMinRange = 0.0f;
	public float yMaxRange = 0.0f;
	public float zMinRange = -25.0f;
	public float zMaxRange = 25.0f;
	public GameObject[] spawnObjects; // what prefabs to spawn
	private int numberOfAnimals=0;
	public int maxSpawnLimit=5;
	private float nextSpawnTime;
	// Use this for initialization
	void Start () {
		//nextSpawnTime = Time.time+secondsBetweenSpawning;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gm) {
			if (GameManager.gm.gameIsOver)
				return;
		}

		// if time to spawn a new game object
		if (numberOfAnimals<=maxSpawnLimit) {

			Debug.Log("Spawned animal\n");

			// Spawn the game object through function below
			MakeThingToSpawn ();

			// determine the next time to spawn the object
			//nextSpawnTime = Time.time+secondsBetweenSpawning;
		}
	}

	void MakeThingToSpawn ()
	{
		Vector3 spawnPosition;
		numberOfAnimals++;
		// get a random position between the specified ranges
		spawnPosition.x = Random.Range (xMinRange, xMaxRange);
		spawnPosition.y = Random.Range (yMinRange, yMaxRange);
		spawnPosition.z = Random.Range (zMinRange, zMaxRange);

		// determine which object to spawn
		int objectToSpawn = Random.Range (0, spawnObjects.Length);
		Debug.Log (objectToSpawn);
		// actually spawn the game object
		GameObject spawnedObject = Instantiate (spawnObjects [objectToSpawn], spawnPosition, transform.rotation) as GameObject;

		// make the parent the spawner so hierarchy doesn't get super messy
		spawnedObject.transform.parent = gameObject.transform;
	}
}*/
public float secondsBetweenSpawning = 0.1f;
public float xMinRange = -25.0f;
public float xMaxRange = 25.0f;
public float yMinRange = 8.0f;
public float yMaxRange = 25.0f;
public float zMinRange = -25.0f;
public float zMaxRange = 25.0f;
public GameObject[] spawn; // what prefabs to spawn

private float nextSpawnTime;

// Use this for initialization
void Start ()
{
	// determine when to spawn the next object
	nextSpawnTime = Time.time+secondsBetweenSpawning;
}

// Update is called once per frame
void Update ()
{
	// exit if there is a game manager and the game is over
	if (GameManager.gm) {
		if (GameManager.gm.gameIsOver)
			return;
	}

	// if time to spawn a new game object
	if (Time.time  >= nextSpawnTime) {

		Debug.Log("Hello");

		// Spawn the game object through function below
		MakeThingToSpawn ();

		// determine the next time to spawn the object
		nextSpawnTime = Time.time+secondsBetweenSpawning;
	}	
}

void MakeThingToSpawn ()
{
	Vector3 spawnPosition;

	// get a random position between the specified ranges
	spawnPosition.x = Random.Range (xMinRange, xMaxRange);
	spawnPosition.y = Random.Range (yMinRange, yMaxRange);
	spawnPosition.z = Random.Range (zMinRange, zMaxRange);

	// determine which object to spawn
	int objectToSpawn = Random.Range (0, spawn.Length);

	// actually spawn the game object
	GameObject spawnedObject = Instantiate (spawn [objectToSpawn], spawnPosition, transform.rotation) as GameObject;

	// make the parent the spawner so hierarchy doesn't get super messy
	spawnedObject.transform.parent = gameObject.transform;
}
}
