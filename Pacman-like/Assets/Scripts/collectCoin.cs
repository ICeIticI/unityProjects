using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoin : MonoBehaviour{
  
  public AudioSource collectSound;
 
  void OnTriggerEnter(Collider other)
   {
       collectSound.Play();
       scoringScript.theScore += 50;
         Destroy(gameObject);
   }
    }
