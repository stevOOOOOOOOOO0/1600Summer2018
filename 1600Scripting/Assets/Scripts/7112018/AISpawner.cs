using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{

	public GameObject AI;
	public Transform Destination;
	public Level CurrentLevel;
	private int aiCount;
	private Transform startingLocation;
	
	// Use this for initialization
	void Start ()
	{
		startingLocation = GetComponent<Transform>();
		aiCount = CurrentLevel.AICount;
		StartCoroutine(StartSpawn());
	}

	IEnumerator StartSpawn()
	{
		while (aiCount > 0)
		{
			//Spawn Zombie
			GameObject newAI = Instantiate(AI);
			AI.transform.position = startingLocation.position;
			newAI.GetComponent<AIMovement>().Destination = Destination;
			yield return new WaitForSeconds(CurrentLevel.Time);
			aiCount--;
		}
	}
}