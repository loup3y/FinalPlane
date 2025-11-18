using UnityEngine;

public class  GunPlacement: MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset = new Vector3(0,2,1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
