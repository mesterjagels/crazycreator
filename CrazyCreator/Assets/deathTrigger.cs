using UnityEngine;
using System.Collections;

public class deathTrigger : MonoBehaviour {
	
	public GameObject killer;

	// Update is called once per frame
	void Update () {
	
	}

	/*void OnCollisionEnter(Collision col){
		Debug.Log ("Is colliding");

		if (GameObject.FindWithTag("player")) {
			deathAnimation ();
		}
	}*/

	void deathAnimation(){
		killer.GetComponent<Rigidbody> ().useGravity = true;
	}
	void OnTriggerEnter(Collider other) {
		print ("something is inside me");
	}
}

