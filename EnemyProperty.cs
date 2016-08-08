using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyProperty : MonoBehaviour {

	private Pinkman p;

	public AudioClip hurt;


	public GameObject pinkMan;
	private float enemyLifeTime = 3.0f;


	void Start() {
		p = FindObjectOfType(typeof(Pinkman)) as Pinkman;
	}

	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, pinkMan.transform.position, Time.deltaTime);
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Pellet") {
			Debug.Log ("Found Object");
			AudioSource.PlayClipAtPoint (hurt, pinkMan.transform.position);
			Destroy (this.gameObject, enemyLifeTime);

		} else if (col.gameObject.tag == "Wall") {
				p.wallHealth.transform.localScale -= new Vector3 (transform.localScale.x * p.enemyDamage,
					transform.localScale.y * p.enemyDamage, transform.localScale.z);
			if (p.wallHealth.transform.localScale.x <= 0.0f && p.wallHealth.transform.localScale.y <= 0.0f) {
				SceneManager.LoadScene ("GameOver");
			}
			}
		}
	}
