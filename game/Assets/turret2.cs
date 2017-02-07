using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class turret2 : MonoBehaviour {
	
	public Transform spawnPoint;
	public Transform barrier;
	public GameObject phantomBarrier;
	public Text infoText;
	public Collision item;
	public static int Ammo;
	public string ItemButtonName;
	public string ItemButtonDrop;
	public bool hasBarrier;
	public int Health = 200;
	
	
	private bool inRange;

	

	// Use this for initialization
	void Start () {
	phantomBarrier.GetComponent<MeshRenderer>().enabled = false;
	inRange = false;
	hasBarrier = false;
	Ammo = Shooting.totalAmmo;
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine(BarrierBuy());
		if(Input.GetButton(ItemButtonDrop) && hasBarrier == true && inRange == true ){
				Instantiate (barrier, spawnPoint.position , spawnPoint.rotation);
				phantomBarrier.GetComponent<MeshRenderer>().enabled = false;
				WaveSpawner.totalScore -= 150;
				Shooting.totalAmmo = Ammo;
				inRange = false;
				hasBarrier = false;
				infoText.text = "";
			}
		}
	
	void OnCollisionEnter(Collision item){
	if (item.gameObject.tag == "Store2") {
			inRange = true;
			infoText.text = "Press Q to buy Turret. Cost 150 points";
			
		}
}
	IEnumerator BarrierBuy(){
		if (Input.GetButton (ItemButtonName) && inRange == true){
			if (WaveSpawner.totalScore < 150){
			infoText.text = "Not Enough Points";
			inRange = false;
			yield return new WaitForSeconds (2f);
			infoText.text = "";
			}
		if (WaveSpawner.totalScore >= 150){
			infoText.text = "Press E to place Turret";
			Shooting.totalAmmo = 0;
			phantomBarrier.GetComponent<MeshRenderer>().enabled = true;
			hasBarrier = true;
			yield return new WaitForSeconds (1f);
		}
		}
	}
	public void OnTriggerEnter(Collider boom)
	{

		//If the object that triggered this collision is tagged "Bullet"
		if (boom.gameObject.tag == "Enemy") {
			Health -= 10;
			}

		
		if (boom.gameObject.tag == "Enemy2") {
			Health -= 20;
			}
		
		}
}
	