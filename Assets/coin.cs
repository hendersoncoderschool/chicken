using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour

{
    public GameManager gameManager;
    private bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !collected)
        {
            collected = true;
            gameManager.coins++;
            gameManager.coinText.text = "Coin : " + gameManager.coins.ToString();
            Destroy(gameObject);

        }
    }
}
