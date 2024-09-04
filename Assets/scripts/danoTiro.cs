using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danoTiro : MonoBehaviour
{

    public float velocidade;
    public Saude dano;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        Destroy(gameObject, 5f);

    }
    //void OnCollisionEnter2D(Collision2D colisor)
    //{
        //if (colisor.tag == "Player")
        //{
          //  Destroy(gameObject);

            //var player = colisor.gameObject.transform.GetComponent();
            //player.PerdeVida(dano);
        //}

    }
//}

