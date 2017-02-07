using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

		public GameObject target = null;
		private UnityEngine.AI.NavMeshAgent navComponent;
		public bool isnotdragon;
		
		void Start() 
		{
			InvokeRepeating("UpdateTarget",0f,0.01f);
			navComponent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		}
		void UpdateTarget(){
		
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Player");
		float shorestDis = Mathf.Infinity;
		foreach (GameObject Player in enemies)
		{
			float disToEnemy = Vector3.Distance(transform.position, Player.transform.position);
			
			if(disToEnemy < shorestDis){
				shorestDis = disToEnemy;
				target = Player;
			}
		}
		}
		
		void Update() 
	{
			float mindistance = 0.5f;
			if(Vector3.Distance(target.transform.position, transform.position) > mindistance)
			{ 
			navComponent.SetDestination(target.transform.position);
			}	
			else
			{
				navComponent.SetDestination(transform.position);
			}
	}
}