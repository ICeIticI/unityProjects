using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScript : MonoBehaviour
{
    private Vector3 startpos;
   
    // Start is called before the first frame update
    void Start()
    {
         startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
           if (transform.position.y < -10) transform.position = startpos;
    }
}
