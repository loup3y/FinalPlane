using System.Collections;
using UnityEngine;

public class DestroyMissed : MonoBehaviour
{
    //public Transform plane;
    //public GameObject plane;
    //public float destroyRadius = 50f;
    public float lifetime = 2.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, lifetime);
        //if (plane == null)
        {
            //enabled = false;
           // return;
        }
        //float distance = Vector3.Distance(transform.position,plane.position);

       // if (distance > destroyRadius) { Destroy(gameObject); }
       
    }
    
    
      
    
        
}

