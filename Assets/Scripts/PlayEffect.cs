using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEffect : MonoBehaviour {

    public AudioClip Effect;
    public AudioSource Source;
	// Use this for initialization
	void Start () {
        Source.clip = Effect;
        Source.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
