using UnityEngine;
using System.Collections;

public class Powerups : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
	StartCoroutine(TimeLimit());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter(Collider boom)
	{
		//If the object that triggered this collision is tagged "Bullet"
		if (boom.gameObject.tag == "Player") {
				Shooting.totalAmmo += 25;
				Destroy (gameObject);
				
			}
		
		}
	IEnumerator TimeLimit()	{
			yield return new WaitForSeconds (20f);
			Destroy(gameObject);
	}
	}
	