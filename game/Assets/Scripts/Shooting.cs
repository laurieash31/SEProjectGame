using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {

	public Rigidbody bullet;
	public Transform bulletspawn;
	public Transform bulletspawn2;

	public char weaponSelected = 'Q';
	public int speed;

	public float firingrate;
	public float delay;

	public static int totalAmmo = 100;
	public int clipSize = 10;

	public Text Ammo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ammo.text = "Ammo: " + totalAmmo;
		/*if (Input.GetButton ("Q")){
			weaponSelected = 'Q';
		}
		if (Input.GetButton ("E")){
			weaponSelected = 'E';
		}
		if (Input.GetButton ("R")){
			weaponSelected = 'R';
		}

		if(weaponSelected == 'Q'){
		*/	
			if (Input.GetButton ("Fire1") && Time.time > delay && totalAmmo != 0) {

				Rigidbody bulletInstance;
				bulletInstance = Instantiate(bullet, bulletspawn.position, bulletspawn.rotation) as Rigidbody;
				bulletInstance.AddForce (bulletspawn.forward * speed);
				delay = Time.time + firingrate;
				totalAmmo--;
		//}
		}
	}
}