using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    public GameObject plane;
    private Vector3 Offset = new Vector3 (20, 5, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + Offset ;
    }
}
