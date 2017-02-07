using UnityEngine;
using System.Collections;

public class OozeGUI : MonoBehaviour {
	Transform focusTarget;
	GameObject[] target = new GameObject[10];
	Animator[] animator = new Animator[10];
	int focusTargetIndex = 0;
	public float buttonPotisionLeft;
	public float buttonPotisionTop;
	public float buttonWidth;
	public float buttonHeight;
	public float cameraHeight;
	public float cameraDistance;
	public string[] action;


	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectsWithTag("Ooze");
		for( int oozeIndex = 0; oozeIndex < target.Length ; oozeIndex++)
		{
		animator[oozeIndex] = target[oozeIndex].GetComponent<Animator>();
		}
		focusTarget = target[focusTargetIndex].transform;

	}
	void Update () {
		Vector3 temp;
		temp.x = focusTarget.position.x;
		temp.y = focusTarget.position.y + cameraHeight;
		temp.z = focusTarget.position.z - cameraDistance;
		transform.position = temp;
		transform.rotation = Quaternion.LookRotation(focusTarget.position - transform.position);


	}
	
	void OnGUI(){
		for( int i = 0; i < action.Length ; i++){
		if(GUI.Button(new Rect(buttonPotisionLeft , buttonPotisionTop + buttonHeight * i , buttonWidth ,buttonHeight),action[i])){
				for( int index = 0 ; index < target.Length; index ++){
					animator[index].SetBool(action[i],true);
				}
		}  
				}
		if(GUI.Button(new Rect(buttonPotisionLeft , buttonPotisionTop + buttonHeight * 5, buttonWidth , buttonHeight),"Change Focus")){
			if(focusTargetIndex +2 > target.Length){
				focusTargetIndex = 0;
				focusTarget = target[focusTargetIndex].transform;
			}
			else{
				focusTargetIndex ++;
				focusTarget = target[focusTargetIndex].transform;
			}
		}

		GUI.Label(new Rect(buttonPotisionLeft, buttonPotisionTop + buttonHeight * 6, buttonWidth, buttonHeight),"move w,a,d");
}
}
