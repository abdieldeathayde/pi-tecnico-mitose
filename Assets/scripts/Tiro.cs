using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {

	
	public GameObject projetil;
	public float forca = 1.0f;
    public GameObject player;

    public AudioClip shootSFX;

    public void tiro()
    {
       
            {
                if (projetil)
                {


                    

                    GameObject newProjectile = Instantiate(projetil, transform.position + transform.forward, transform.rotation) as GameObject;

                   newProjectile.transform.Translate(Vector3.up);


                    if (!newProjectile.GetComponent<Rigidbody2D>())
                    {
                        newProjectile.AddComponent<Rigidbody2D>();
                    }

                    Vector3 alvo = player.transform.position;
                    Vector3 posicao = newProjectile.transform.position;
                
                    newProjectile.GetComponent<Rigidbody2D>().AddForce((alvo-posicao).normalized * forca);

                

                    if (shootSFX)
                    {
                        if (newProjectile.GetComponent<AudioSource>())
                        {

                            newProjectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                        }
                        else
                        {

                            AudioSource.PlayClipAtPoint(shootSFX, newProjectile.transform.position);
                        }

                    }
                }
            }

        
    }
	

	
	void Start () {
        InvokeRepeating("tiro", 1.0f, 1.0f);
        player = GameObject.FindWithTag("Player");


}
	void Update () {
		
			
			
	}
    


	}
