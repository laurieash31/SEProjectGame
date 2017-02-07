using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge : MonoBehaviour {
    public Transform notebook;
    public Transform Spwn;

    

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnTime());
       
        
    }
	
	// Update is called once per frame
	void Update () {
       

    }
    IEnumerator SpawnTime()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(notebook, Spwn.position, Spwn.rotation);
        Destroy(gameObject);
    }
}
