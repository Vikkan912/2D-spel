using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreText : MonoBehaviour
{
    //Private betyder att man inte ser det i "spelet" (scriptet). Man skrivr in det för att göra det till en variabel. För att kunna använda den i scriptet.
    private TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        //text hämtar en TextMeshPro när spelet startar.
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Text gör så att det blir en string (En text). Och stringen skriver ut det röda. Det fyra nollorna är beroende av hur stor/ hur många siffror Coin.score är. 
        text.text = string.Format("score:  {0:0000}", Coin.score);  
       
    }
}
