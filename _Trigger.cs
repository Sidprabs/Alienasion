using UnityEngine;
using System.Collections;

public class _Trigger : MonoBehaviour {

	public GameObject ee1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			ee1.GetComponent<EnemyMove> ().enabled = true;
			Debug.Log ("Check");
		}
	}
}
