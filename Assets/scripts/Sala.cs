using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sala : MonoBehaviour
{
    public AudioClip shootSFX;
    public GameObject porta;
    public GameObject NextLevelCanvas;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            porta.GetComponent<AudioSource>().PlayOneShot(shootSFX);
            AudioSource.PlayClipAtPoint(shootSFX, porta.transform.position);
            //SceneManager.LoadScene("Sala");
            NextLevelCanvas.SetActive(true);
        }
    }
}
