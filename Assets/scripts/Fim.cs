using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fim : MonoBehaviour {
    public Canvas canvasFim;
	public GameObject botao;

	
	void Start () {
		Button btn= botao.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		
	}
	
	
	void Update () {
		
	}

	void TaskOnClick()
	{


		SceneManager.LoadScene("Menu");





	}
}

