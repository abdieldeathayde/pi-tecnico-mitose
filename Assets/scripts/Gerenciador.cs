using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Gerenciador : MonoBehaviour {

	public static Gerenciador ger;

	
	public GameObject player;
	public Saude saude;


	public int score=5;
	public bool canBeatLevel = false;
	public int beatLevelScore=0;

	public GameObject mainCanvas;
	public Text mainScoreDisplay;
	public GameObject gameOverCanvas;
	

	
	public GameObject beatLevelCanvas;

	//public AudioSource backgroundMusic;
	//public AudioClip gameOverSFX;

	
	//public AudioClip beatLevelSFX;

	void Start () {

       


        if (ger == null) 
			ger = gameObject.GetComponent<Gerenciador>();

		if (player == null) {
			player = GameObject.FindWithTag("Player");
		}

        saude = player.GetComponent<Saude>();
		
		Collect (0);
		

		

	}

	void Update () {
		
				if (saude.morto == false)
				{
					
					

					
					

						
					
					
				} else if (canBeatLevel && score>=beatLevelScore) {
					
					

					
					player.SetActive(false);

								
					mainCanvas.SetActive (false);
					beatLevelCanvas.SetActive (true);
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


        }
        
 