using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Barrier2 : MonoBehaviour {
	
	public Transform spawnPoint;
	public Transform barrier;
	public GameObject phantomBarrier;
	public Transform store;
	public Transform player;
	public Text infoText;
	public Collision boom;
	
	private bool inRange;

	// Use this for initialization
	void Start () {
	phantomBarrier.GetComponent<MeshRenderer>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Submit") && inRange == true){
			phantomBarrier.GetComponent<MeshRenderer>().enabled = true;
			if(Input.GetButton("Submit")){
				Instantiate (barrier, spawnPoint.position , spawnPoint.rotation);
				phantomBarrier.GetComponent<MeshRenderer>().enabled = false;
			}
		}
	}
	public void OnCollisionEnter(Collision boom){
	if (boom.gameObject.tag == "Store") {
			inRange = true;
			infoText.text = "In Range";
		}
}
}