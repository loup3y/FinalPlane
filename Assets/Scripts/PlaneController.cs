using JetBrains.Annotations;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float verticalInput;
   
    public GameObject projectilePrefab;
    public float pitchSpeed= 10.0f;
    public GameObject gunMount;
    public float fireDelay = 0.1f;
    public float chamber = 0.0f;
   
   // private float planeBoundhorizontal = 50;
   // private float planeBoundvertical = 50;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        verticalInput = Input.GetAxis("Vertical");
       
        transform.Rotate(Vector3.right, Time.deltaTime * pitchSpeed * verticalInput);

        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time >= chamber) 
            { Instantiate(projectilePrefab, gunMount.transform.position, transform.rotation);
                chamber = Time.time + fireDelay;
            }
        }
        else if (Time.time< chamber) { float remaining = chamber - Time.time; }
         
       // if (transform.position.z > planeBoundhorizontal) {Destroy(gameObject); }
       // else if (transform.position.z < -planeBoundhorizontal) { Destroy(gameObject); }
       // if (transform.position.y > planeBoundvertical) { Destroy(gameObject); }
        //else if(transform.position.y < -planeBoundvertical) { Destroy(gameObject); }
    }
}
