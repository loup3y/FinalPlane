using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float verticalInput;
    
    public float pitchSpeed= 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right, Time.deltaTime * pitchSpeed * verticalInput);

    }
}
