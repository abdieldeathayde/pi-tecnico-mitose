using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Continuar : MonoBehaviour {
	public string nivel;
	public GameObject botao;

	void Start () {
		//level = (LevelLoad) GameObject.FindObjectOfType<LevelLoad> ().GetComponent<LevelLoad>() ;
		Button btn = botao.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		
	}
	
	
	void Update () {
        

    }
	void TaskOnClick()
	{
		if (PlayerPrefs.HasKey("Fase")) {
			
			nivel = PlayerPrefs.GetString ("Fase");
			SceneManager.LoadScene (nivel);

		}
		//else {
			//SceneManager.LoadScene ("Aluno");

		/*if (level.salvaFase == "Corredor") {
			SceneManager.LoadScene ("Corredor");
		}
		if (level.salvaFase == "Sala") {
			SceneManager.LoadScene ("Sala");
		*/

	//}
        
    }
    
}



