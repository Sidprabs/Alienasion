using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour {

	public float deathDistance = 0.5f;
	public float distanceAway;
	public Transform thisObject;
	public Transform target;
	private UnityEngine.AI.NavMeshAgent navComponent;

	void Start () {
	
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();

	}

	void OnTriggerEnter(Collider p){
		if (p.gameObject.tag == "Player") {
			Debug.Log ("touch");
			SceneManager.LoadScene(8);
		}
	}

	void Update () {
	
		float dist = Vector3.Distance (target.position, transform.position);

		if (target) {
			navComponent.SetDestination (target.position);
		}
		else
		{
			if (target = null) {
				target = this.gameObject.GetComponent<Transform> ();
			}
				else
				{
					target = GameObject.FindGameObjectWithTag("Player").transform;
				}
			}
			if(dist<= deathDistance)
			{

			}

		if (this.GetComponent<CapsuleCollider> ().radius <= 0.5) {
		
		
		}
		}



	}
