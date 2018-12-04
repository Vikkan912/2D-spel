using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    //hur många poäng som behövs för att vinna.
    public int minimumScoreNeeded = 0;
    //Vilken scene spelet ska ladda.
        public string sceneToLoad = "2d";

    //Om en sak gå in i den andras collider. Så kommer något att hända.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //&& = och
        //***
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            //hur mycket pengar du har när du börjar. 
            Coin.score = 0;
            //Gör bara så att du loadar en level.
            SceneManager.LoadScene(sceneToLoad);    

        }
    }
}
