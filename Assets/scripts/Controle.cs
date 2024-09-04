using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controle : MonoBehaviour
{
	public AudioClip Musica;
    public int velocidade = 10;
	private bool direita = true;
	public int forçaDoPulo = 1250;
	private float moveX;

	private bool noChao;
	public LayerMask chao;
	public Transform terra;
    
    public Text mainScoreDisplay;
    public GameObject projetil;

	
	public static Controle controle;


	public static int score=5;
	public bool canBeatLevel = false;
    public int beatLevelScore = 0;



    public GameObject mainCanvas;

	public GameObject gameOverCanvas;
	public GameObject player;
	public Saude saude;


	//public GameObject beatLevelCanvas;
	bool pause;



  




    void Start () {

		if (controle == null) {
			controle = gameObject.GetComponent<Controle> ();
			pause = true;
            
		}
        

		if (player == null) {
			player = GameObject.FindWithTag ("Player");
		}

		saude = player.GetComponent<Saude> ();

		Collect (0);
	}

       

    void Update()
	{
		moveJogador ();





		if (saude.morto == false) {



		} else if (canBeatLevel && score >= beatLevelScore) {




			player.SetActive (false);


			mainCanvas.SetActive (false);
			//beatLevelCanvas.SetActive (true);



		}
		if (Input.GetKeyDown(KeyCode.Escape)){
			if (pause){
				Time.timeScale=0;
				pause=false;

			}
			else{
				Time.timeScale=1;
				pause=true;
			}


		}
	}

    
    void LateUpdate(){
      viraJogador();
    
}

    void moveJogador()
    {
        moveX = Input.GetAxis("Horizontal");
        noChao = Physics2D.Linecast (transform.position, terra.position, chao);
        if (Input.GetButtonDown("Jump") && noChao)
        {
            pula();
        }
        
                    
        gameObject.GetComponent < Rigidbody2D> ().velocity = new Vector2(moveX * velocidade, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        Physics2D.IgnoreLayerCollision(this.gameObject.layer,
            LayerMask.NameToLayer("chao"),
            (gameObject.GetComponent<Rigidbody2D>().velocity.y > 0.0f));
    }
    void pula()
    {
	GetComponent<Rigidbody2D> ().AddForce (Vector2.up * forçaDoPulo);

    }
    
    public void ColetaMoeda(int valor) {
		//PlaySound(SomMoeda);

		if (controle) 
			Controle.controle.Collect(valor);
	}
		
	void viraJogador(){
		if (moveX > 0) {
			direita = true;
		} else if (moveX < 0) {
			direita = false;
		}
		Vector2 escala = transform.localScale;
		if ((escala.x > 0 && !direita) || (escala.x < 0 && direita)) {
			escala.x = escala.x * -1;
			transform.localScale = escala;
		}
        
        }
    void OnCollisionEnter2D(Collision2D other)
    {
		if (other.gameObject.tag== "Projetil")
        {
            
            score --;
            mainScoreDisplay.text = score.ToString();


        }

    }
	public void Collect(int amount) {
		score += amount;
		if (canBeatLevel) {
			mainScoreDisplay.text = score.ToString ();
		} else {
			mainScoreDisplay.text = score.ToString ();

		}

	}
	public void Pontos(){
		score += 1;
		mainScoreDisplay.text = score.ToString();
	}
	public void tiraPontos(){
		score -= 1;
		mainScoreDisplay.text = score.ToString();
	}

}