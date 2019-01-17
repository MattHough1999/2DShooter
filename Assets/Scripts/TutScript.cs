using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var spawn = GameObject.Find("Spawner");
        spawn.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void EnableSpawner()
    {
        var spawn = GameObject.Find("Spawner");
        spawn.SetActive(true);
    }
    
}
