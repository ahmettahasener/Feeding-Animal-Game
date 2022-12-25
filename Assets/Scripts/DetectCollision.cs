using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    // Start is called before the first frame update
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !gameObject.CompareTag("Pizza"))
        {
            Debug.Log("Game Over");
            gameManager.AddLives(-1);
            //Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(5);
            //Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
