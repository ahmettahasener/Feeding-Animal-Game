using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float nearBound = 30.0f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); //pizzayý ekran sýnýfýrýný aþýnca yok et
        }
        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);//hayvanlarý sýnýrý aþýnca yok et
            gameManager.AddLives(-1);
        }
        if (transform.position.x > nearBound)
        {
            Destroy(gameObject);
            //gameManager.AddLives(-1);
        }
        if (transform.position.x < -nearBound)
        {
            Destroy(gameObject);
            //gameManager.AddLives(-1);
        }
    }
}
