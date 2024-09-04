using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animacaoPorta : MonoBehaviour {

	public Animation animation;
	public AudioSource audio;
	private bool AbrirPorta;

	// Use this for initialization
	void Start () {
		this.AbrirPorta = false;
		
	}
	
	
	
	
	
	private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( !this.AbrirPorta && collision.tag == "Player")
        {
        audio.Play();
        
        //AbrirPorta.SetActive("true");
        this.AbrirPorta = true;
    
    }

		
	}
}
