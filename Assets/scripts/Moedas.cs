using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : MonoBehaviour {

	public int valor =1;
	private bool foiPega=false;
	public GameObject explosao;
		
	void OnTriggerEnter2D(Collider2D outro){
		if (outro.tag == "Player" && !foiPega){
		foiPega = true;
		
		
		if(explosao ){
		Instantiate (explosao, transform.position, transform.rotation);
	}
	
	outro.gameObject.GetComponent < Controle> (). ColetaMoeda (valor);
	DestroyObject (this.gameObject);
}
}
}
