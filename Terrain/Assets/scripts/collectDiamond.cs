using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectDiamond : MonoBehaviour{
  
  public AudioSource collectSound;
 
  void OnTriggerEnter(Collider other)
   {
       collectSound.Play();
       scoringScript.theScore += 1;
         Destroy(gameObject);
   }
    }
