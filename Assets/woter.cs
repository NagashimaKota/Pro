using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class woter : MonoBehaviour {

    private AudioSource adio;

	void Start ()
    {
		adio = this.GetComponent<AudioSource>();
    }
	
	
	void Update ()
    {
        
    }
    
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            adio.mute = false;
        }
        else
        {
            adio.mute = true;
        }
    }

}
