using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoProfase : MonoBehaviour {
    public static int score;
    public GameObject Botaoo;
    
    public GameObject BotaoAnafase;
    public GameObject BotaoTelofase;
    public GameObject BotaoMetafase;

    
    public Text mainScoreDisplay;

    public Image profase;
    public Image metafase;
	public Image anafase;
	public Image telofase;

    public GameObject Botaometafase2;
    public GameObject BotaoProfase2;
    public GameObject BotaoAnafase2;
    public GameObject BotaoTelofase2;
    public GameObject BotaoProfase3;
    public GameObject BotaoMetafase3;
    public GameObject BotaoAnafase3;
    public GameObject BotaoTelofase3;
    public GameObject BotaoProfase4;
    public GameObject BotaoMetafase4;
    public GameObject BotaoAnafase4;
    public GameObject BotaoTelofase4;
	public static Controle controle;

	public GameObject botaoAcerto;
	public GameObject botaoErro;



	public Text t1;
	public Text t2;
	public Text t3;
	public Text t4;
    
	public GameObject buttoonMetafase;
	public GameObject buttoonProfase;
	public GameObject buttoonTelofase;
	public GameObject buttoonAnafase;
	public Canvas CanvasInf;

	public GameObject ok1;
	public GameObject ok2;
	public GameObject ok3;
	public GameObject ok4;

	public void awake(){

	}
 
    void Start()
    {
		


		Button botao = buttoonProfase.GetComponent<Button> ();
		Button botao2 = buttoonMetafase.GetComponent<Button> ();
		Button botao3 = buttoonAnafase.GetComponent<Button> ();
		Button botao4 = buttoonTelofase.GetComponent<Button> ();

		Button ok1 = buttoonProfase.GetComponent<Button> ();
		Button ok2 = buttoonMetafase.GetComponent<Button> ();
		Button ok3 = buttoonAnafase.GetComponent<Button> ();
		Button ok4 = buttoonTelofase.GetComponent<Button> ();



        controle = (Controle) GameObject.FindObjectOfType<Controle> ().GetComponent<Controle>() ;
        PlayerPrefs.SetString("Fase", "Laboratório");

            Button btn = Botaoo.GetComponent<Button> ();
			Button btn2 = BotaoMetafase.GetComponent<Button> ();
			Button btn3 = BotaoAnafase.GetComponent<Button> ();
			Button btn4 = BotaoTelofase.GetComponent<Button> ();

			Button btn5 = BotaoProfase2.GetComponent<Button> ();
			Button btn6 = Botaometafase2.GetComponent<Button> ();
			Button btn7 = BotaoAnafase2.GetComponent<Button> ();
			Button btn8 = BotaoTelofase2.GetComponent<Button> ();

			Button btn9 = BotaoProfase3.GetComponent<Button> ();
			Button btn10 = BotaoMetafase3.GetComponent<Button> ();
			Button btn11 = BotaoAnafase3.GetComponent<Button> ();
			Button btn12 = BotaoTelofase3.GetComponent<Button> ();

			Button btn13 = BotaoProfase4.GetComponent<Button> ();
			Button btn14 = BotaoMetafase4.GetComponent<Button> ();
			Button btn15 = BotaoAnafase4.GetComponent<Button> ();
			Button btn16 = BotaoTelofase4.GetComponent<Button> ();

			btn.onClick.AddListener (TaskOnClick);
			btn2.onClick.AddListener (TaskOnClick2);
			btn3.onClick.AddListener (TaskOnClick3);
			btn4.onClick.AddListener (TaskOnClick4);

       
			btn5.onClick.AddListener (TaskOnClick5);
			btn6.onClick.AddListener (TaskOnClick6);
			btn7.onClick.AddListener (TaskOnClick7);
			btn8.onClick.AddListener (TaskOnClick8);

			btn9.onClick.AddListener (TaskOnClick9);
			btn10.onClick.AddListener (TaskOnClick10);
			btn11.onClick.AddListener (TaskOnClick11);
			btn12.onClick.AddListener (TaskOnClick12);

			btn13.onClick.AddListener (TaskOnClick13);
			btn14.onClick.AddListener (TaskOnClick14);
			btn15.onClick.AddListener (TaskOnClick15);
			btn16.onClick.AddListener (TaskOnClick16);


			ok1.onClick.AddListener (TaskOnClick17);
			ok2.onClick.AddListener (TaskOnClick18);
			ok3.onClick.AddListener (TaskOnClick19);
			ok4.onClick.AddListener (TaskOnClick20);
		
	}

	void Update(){
		
        transform.localPosition = new Vector3(0, 0, 2);

    }

    void TaskOnClick()
    {
		

	
		botaoAcerto.SetActive (true);

        
		controle.Pontos();
        Destroy(profase);

        Destroy(BotaoAnafase);
        Destroy(BotaoMetafase);
		Botaoo.SetActive (false);
        Destroy(BotaoTelofase);


        metafase.enabled = true;
        BotaoProfase2.SetActive(true);
        BotaoAnafase2.SetActive(true);
        BotaoTelofase2.SetActive(true);
        Botaometafase2.SetActive(true);


		botaoAcerto.SetActive (false);
    }

    void TaskOnClick2()
    {
		
		botaoErro.SetActive (true);
		controle.tiraPontos();

    }
    void TaskOnClick3()
    {
		botaoErro.SetActive (false);
		botaoErro.SetActive (true);
		controle.tiraPontos();
    }
    void TaskOnClick4()
    {
      
		controle.tiraPontos();
    }


    void TaskOnClick5()
    {
       
		controle.tiraPontos();
    }

    void TaskOnClick6()
    {
		botaoErro.SetActive (false);
		botaoAcerto.SetActive (true);
		controle.Pontos();
        Destroy(metafase);

        Destroy(BotaoAnafase2);
        Destroy(Botaometafase2);
        Destroy(BotaoProfase2);
        Destroy(BotaoTelofase2);

		anafase.enabled = true;
            
		BotaoProfase3.SetActive(true);
		BotaoAnafase3.SetActive(true);
		BotaoTelofase3.SetActive(true);
		BotaoMetafase3.SetActive(true);

    }

    void TaskOnClick7()
    {
		botaoErro.SetActive (true);
		controle.tiraPontos();
    }

    void TaskOnClick8()
    {
   
		controle.tiraPontos();
    }


    void TaskOnClick9()
    {
       
		controle.tiraPontos();
    }

    void TaskOnClick10()
    {
       
		controle.tiraPontos();
    }

    void TaskOnClick11()
    {
		botaoErro.SetActive (false);

		botaoAcerto.SetActive (true);
		controle.Pontos();
		Destroy (anafase);

        Destroy(BotaoAnafase3);
        Destroy(BotaoMetafase3);
        Destroy(BotaoProfase3);
        Destroy(BotaoTelofase3);


		telofase.enabled =true;
		BotaoProfase4.SetActive(true);
		BotaoAnafase4.SetActive(true);
		BotaoTelofase4.SetActive(true);
		BotaoMetafase4.SetActive(true);
    }
    void TaskOnClick12()
    {
		botaoErro.SetActive (true);
		controle.tiraPontos();
    }
    void TaskOnClick13()
    {
  
		controle.tiraPontos();
    }
    void TaskOnClick14()
    {
     
		controle.tiraPontos();
    }
    void TaskOnClick15()
    {
  
		controle.tiraPontos();
    }
    void TaskOnClick16()
    {
		botaoErro.SetActive (false);
 
		botaoAcerto.SetActive (true);
		controle.Pontos();
		Destroy (telofase);

        Destroy(BotaoAnafase4);
        Destroy(BotaoMetafase4);
        Destroy(BotaoProfase4);
        Destroy(BotaoTelofase4);


		CanvasInf.enabled = true;




    }
	void TaskOnClick17()
	{
		
		Destroy (buttoonProfase);
		buttoonMetafase.SetActive (true);

		
	}
	void TaskOnClick18()
	{
		
		Destroy (buttoonMetafase);
		buttoonAnafase.SetActive (true);

	}
	void TaskOnClick19()
	{
		
		Destroy (buttoonAnafase);
		buttoonTelofase.SetActive (true);

	}
	void TaskOnClick20()
	{
		
		Destroy (buttoonTelofase);
	}
}