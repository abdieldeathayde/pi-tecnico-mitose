using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {
	public static int[] chaves;
	public static bool SalvarChaves;
	public GameObject[] Datas;

	void Awake(){
		chaves = new int[30];
		Datas = GameObject.FindGameObjectsWithTag ("DATA");
		if (Datas.Length >= 2) {
			Destroy (Datas [0]);


		}
		DontDestroyOnLoad (transform.gameObject);


	}

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetString("Fase", "Aluno");
        
        SalvarChaves = false;
		for (int i = 0; i < 30; i++) {
			if (PlayerPrefs.HasKey ("nome " + i)) {
				chaves[i] = PlayerPrefs.GetInt("nome" +i);
                chaves[i] = PlayerPrefs.GetInt("fase" + i);
                


            }
		}
	}

	void funcaoSalvarChaves(){
		for (int i = 0; i < 30; i++) {
			PlayerPrefs.SetInt ("nome " +i, chaves[i]);
            PlayerPrefs.SetInt("fase " + i, chaves[i]);

        }

	}
	

	void Update () {
		if (SalvarChaves == true) {
			funcaoSalvarChaves ();
			SalvarChaves = false;
            

        }
	}
}
