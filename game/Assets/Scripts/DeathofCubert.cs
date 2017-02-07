using UnityEngine;
using System.Collections;
using UnityEngine.UI; 





public class DeathofCubert : MonoBehaviour {

	public int life = 0; 
	private int rnd1;
	public static int newScore;
	public Transform itemSpawn;
	public int rndPercentage =2;
	public Transform item;

	private int spawnLocation;


	// Use this for initialization
	void Start () {
		newScore = 0;
	}

	// Update is called once per frame
	void Update () {
		

	}
	public void OnCollisionEnter(Collision boom)
	{
		//If the object that triggered this collision is tagged "Bullet"
		if (boom.gameObject.tag == "Bullet") {
			life += 1;
			if (life == 2) {
				spawnLocation = Random.Range (0, 2);
				if(spawnLocation ==  1){
					Instantiate (item, itemSpawn.position, itemSpawn.rotation);
				}
				WaveSpawner.numberOfEnemies-=1;
				Destroy (gameObject);
				newScore = 10;
			}

		}

	}

}


