using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FireGun : MonoBehaviour
{
	public Transform PlayerPosition;
	public GameObject Bullet;
	private bool canFire;

	void Start()
	{
		PlayerPosition = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	IEnumerator FireBullets()
	{
		while (canFire)
		{
			GameObject newBullet = Instantiate(Bullet, PlayerPosition.position, PlayerPosition.rotation);
			newBullet.GetComponent<Rigidbody>().velocity = PlayerPosition.forward * 100;
			yield return new WaitForSeconds(.05f);
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
