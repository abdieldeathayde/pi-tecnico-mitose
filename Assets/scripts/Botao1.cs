﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botao1 : MonoBehaviour {
    public string fase;
    public GameObject botao;

	void Start () {
       Button btn= botao.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	

	void Update () {
		
	}
    void TaskOnClick()
    {


        SceneManager.LoadScene(fase);




    }
}
