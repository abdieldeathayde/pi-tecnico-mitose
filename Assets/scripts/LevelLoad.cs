using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {
	
	public string fase;


	void Start () {
	
		
	}
	

	void Update () {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
        	
			SceneManager.LoadScene(fase);
        }
	
    }
	public void salvaFase(){
		if (Input.GetKeyDown ("s")) {
			
			PlayerPrefs.SetString ("Fase", fase);
			Debug.Log ("fase salva");
		}
		
	}
}
