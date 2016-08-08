using UnityEngine;
using System.Collections;

public class Pinkman : MonoBehaviour {
	public AudioClip clip;

	// Player
	public GameObject pinkMan;
	public double playerHealth = 3000;
	public float playerSpeed = 5.0f;
	private float playerFireRate = 0.09f;
	private float playerLastShot = 0.0f;
	public double pelletDamage = 0.05; // 5%
	public float pelletSpeed = 100.0f;

	// Pellet
	public GameObject pellet;

	// Wall Health Bar - Player's Health
	public GameObject wallHealth;

	// Enemies
	public float enemyDamage = 0.000000005f;
	public float enemySpawnRate = 0.5f;
	public float enemyLastSpawn = 0.0f;

	public GameObject evilMan; // The henchmen of the boss
	public GameObject bossMan; // The boss

	// Health orb
	public GameObject healthOrb;
	public double healPercentage = 0.05; // 5%

	// Pellet Spawn Points
	public Transform pelletTopSpawn;
	public Transform pelletBottomSpawn;
	public Transform pelletRightSpawn;
	public Transform pelletLeftSpawn;

	// Enemy Spawn Points
	public Transform enemy1, enemy2, enemy3, enemy4, enemy5, enemy6, enemy7, enemy8, enemy9, enemy10, enemy11, enemy12;

	void FixedUpdate() {
		playerMovement ();
		playerShoot ();
		spawnEnemy ();
//		reduceHealth ();
	}
		
	// Moving the Player with WSAD or Arrow keys
	void playerMovement() {

		if (Input.GetKey ("w") || Input.GetKey ("up")) {

			pinkMan.transform.Translate (Vector2.up * Time.deltaTime * playerSpeed);

		}  

		if (Input.GetKey ("s") || Input.GetKey ("down")) {

			pinkMan.transform.Translate (Vector2.down * Time.deltaTime * playerSpeed);

		}  

		if (Input.GetKey ("a") || Input.GetKey ("left")) {

			pinkMan.transform.Translate (Vector2.left * Time.deltaTime * playerSpeed);

		}  

		if (Input.GetKey ("d") || Input.GetKey ("right")) {

			pinkMan.transform.Translate (Vector2.right * Time.deltaTime * playerSpeed);

		}

	}

	// Make the Player shoot with Space key
	void playerShoot() {

		if (Input.GetKey ("space") && Time.time > playerFireRate + playerLastShot) {

			AudioSource.PlayClipAtPoint(clip, pinkMan.transform.position);

//			Instantiate (pellet, pelletTopSpawn.position, pelletTopSpawn.rotation);
//			Instantiate (pellet, pelletBottomSpawn.position, pelletBottomSpawn.rotation);
//			Instantiate (pellet, pelletLeftSpawn.position, pelletLeftSpawn.rotation);
//			Instantiate (pellet, pelletRightSpawn.position, pelletRightSpawn.rotation);

			GameObject shootUp = (GameObject) Instantiate (pellet, pelletTopSpawn.position, pelletTopSpawn.rotation);
			Rigidbody2D up = shootUp.GetComponent<Rigidbody2D> ();
			up.AddForce (Vector2.up * pelletSpeed);

			GameObject shootDown = (GameObject) Instantiate (pellet, pelletBottomSpawn.position, pelletBottomSpawn.rotation);
			Rigidbody2D down = shootDown.GetComponent<Rigidbody2D> ();
			down.AddForce (Vector2.down * pelletSpeed);

			GameObject shootRight = (GameObject) Instantiate (pellet, pelletRightSpawn.position, pelletRightSpawn.rotation);
			Rigidbody2D right = shootRight.GetComponent<Rigidbody2D> ();
			right.AddForce (Vector2.left * pelletSpeed);

			GameObject shootLeft = (GameObject) Instantiate (pellet, pelletLeftSpawn.position, pelletLeftSpawn.rotation);
			Rigidbody2D left = shootLeft.GetComponent<Rigidbody2D> ();
			left.AddForce (Vector2.right * pelletSpeed);

			playerLastShot = Time.time;
		}

	}
		
	void spawnEnemy() {

		if (Time.time > enemySpawnRate + enemyLastSpawn) {
			GameObject e1 = (GameObject)Instantiate (evilMan, enemy1.position, enemy1.rotation);
			GameObject e2 = (GameObject)Instantiate (evilMan, enemy2.position, enemy2.rotation);
			GameObject e3 = (GameObject)Instantiate (evilMan, enemy3.position, enemy3.rotation);
			GameObject e4 = (GameObject)Instantiate (evilMan, enemy4.position, enemy4.rotation);
			GameObject e5 = (GameObject)Instantiate (evilMan, enemy5.position, enemy5.rotation);
			GameObject e6 = (GameObject)Instantiate (evilMan, enemy6.position, enemy6.rotation);
			GameObject e7 = (GameObject)Instantiate (evilMan, enemy7.position, enemy7.rotation);
			GameObject e8 = (GameObject)Instantiate (evilMan, enemy8.position, enemy8.rotation);


			GameObject e9 = (GameObject)Instantiate (bossMan, enemy9.position, enemy9.rotation);
			GameObject e10 = (GameObject)Instantiate (bossMan, enemy10.position, enemy10.rotation);
			GameObject e11 = (GameObject)Instantiate (bossMan, enemy11.position, enemy11.rotation);
			GameObject e12 = (GameObject)Instantiate (bossMan, enemy12.position, enemy12.rotation);


			enemyLastSpawn = Time.time;
		}
	}

//	void reduceHealth () {
//		if (Input.GetKey ("z")) {
//			Debug.Log ("Reducing health");
//			healthBar.transform.localScale -= transform.localScale;
//		}
//	}
//


}
