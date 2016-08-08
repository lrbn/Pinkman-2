using UnityEngine;
using System.Collections;

public class PelletProperties : MonoBehaviour {

	public float pelletLifeTime = 5.0f;
	
	// Update is called once per frame
	void Update () {
		
		Destroy (this.gameObject, pelletLifeTime);

	}
}
