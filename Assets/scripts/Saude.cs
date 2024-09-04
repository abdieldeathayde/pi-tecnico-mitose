using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Saude : MonoBehaviour {
	
	public static Saude saudee;
    public bool morto;
    public int saude;

    

   
    public GameObject GameOver;

    
    void Start() {
        morto = false;
       
    }

    void Update() {
    }

    public void dano(int x) {
        saude -= x;
        if (saude <= 0) {
            morto = true;

            StartCoroutine(morre());
        }
    }

    internal void dano()
    {
        saude = -1;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projetil") {
            dano();
        }
    }

    public void danoMax() {
        saude = 0;
        morto = true;

        if (gameObject.tag == "Player") {
            StartCoroutine(morre());
        }



    }

    IEnumerator morre() {
        yield return new WaitForSeconds(2.0f);
		if (Controle.controle)
            
            GameOver.SetActive(true);

    }
}
   
