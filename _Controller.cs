using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class _Controller : MonoBehaviour {

	public float moveSpeed = 6;


	Rigidbody rigidbody;
	Camera viewCamera;
	Vector3 velocity;

	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		viewCamera = Camera.main;
		//GetComponent<EnemyMove> ().enabled = false;
	}

	void OnTriggerEnter(Collider e){
		if (e.gameObject.tag == "Exit1") {
			SceneManager.LoadScene (6);
		}
		if (e.gameObject.tag == "Exit2") {
			SceneManager.LoadScene (7);
		}
		if (e.gameObject.tag == "Exit3") {
			SceneManager.LoadScene (9);
		}
	}

	void Update () {
		Vector3 mousePos = viewCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
		transform.LookAt (mousePos + Vector3.up * transform.position.y);
		velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * moveSpeed;
	}

	void FixedUpdate(){
		rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
}
}