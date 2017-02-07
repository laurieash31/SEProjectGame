using UnityEngine;
using System.Collections;

public class OozeController : MonoBehaviour {
	Animator animator;
	bool attack1 = false;
	bool attack2 = false;
	bool attack3 = false;
	bool takeDamage = false;
	bool dead = false;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(animator){
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
			if(Input.GetKeyDown(KeyCode.Alpha1)){
				attack1 = true;
				animator.SetBool("Attack1",attack1);
			}
			if(Input.GetKeyDown(KeyCode.Alpha2)){
				attack2 = true;
				animator.SetBool("Attack2",attack2);
			}
			if(Input.GetKeyDown(KeyCode.Alpha3)){
				attack3 = true;
				animator.SetBool("Attack3",attack3);
			}
			if(Input.GetKeyDown(KeyCode.Alpha4)){
				takeDamage = true;
				animator.SetBool("TakeDamage",takeDamage);
			}
			if(Input.GetKeyDown(KeyCode.Alpha5)){
				dead = true;
				animator.SetBool("Dead",dead);
			}

		animator.SetFloat("h",h);
		animator.SetFloat ("v",v);
		}
	}
}
