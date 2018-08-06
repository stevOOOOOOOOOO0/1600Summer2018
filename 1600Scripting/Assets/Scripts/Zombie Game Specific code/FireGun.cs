using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FireGun : MonoBehaviour
{
	public Transform playerPosition;
	public GameObject Bullet;
	private bool canFire;

	void Start()
	{
		playerPosition = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	IEnumerator FireBullets()
	{
		while (canFire)
		{
			GameObject newBullet = Instantiate(Bullet, playerPosition.position, playerPosition.rotation);
			yield return new WaitForSeconds(.5f);
		}
	}

	private void Update()
	{
		
		if (Input.GetAxis("Fire1") == 0f)
			canFire = false;
		else if (canFire)
			return;
		if (Input.GetAxis("Fire1") != 0f)
		{
			canFire = true;
			StartCoroutine(FireBullets());
		}
	}
}
