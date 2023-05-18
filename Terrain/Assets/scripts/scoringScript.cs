using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringScript : MonoBehaviour {
   public GameObject scoreText;
   public GameObject scoreText2;
   public static int theScore;

   void Update()
   {
       scoreText.GetComponent<Text>().text = "Diamonds: " + theScore;
       scoreText2.GetComponent<Text>().text = "Diamonds: " + theScore;
   }

}
