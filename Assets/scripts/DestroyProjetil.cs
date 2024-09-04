using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyProjetil : MonoBehaviour {


	public float velocidade;

	

    

    void Start () {
		Destroy(gameObject, 1f);
	}
	

	void Update () {
		transform.Translate (Vector2.left * velocidade * Time.deltaTime);
        


		
		
		
	}

}
