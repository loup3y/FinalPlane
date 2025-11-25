using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject plane;
    public Vector3 offset = new Vector3(0, 0, 9);
    private Vector3 spawnPos;
    //public float spawnPosx = 9;
    public int startDelay = 2;
   private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
        // Vector3 spawnPos= transform.position;
        // transform.position = plane.transform.position + offset;
        //Instantiate(enemyPrefab);
        // SpawnEnemy();
        //InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab);
        Vector3 spawnPos = (transform.position);
        if (Time.time>= startDelay )
        { transform.position = plane.gameObject.transform.position + offset; }
         //transform.position = plane.gameObject.transform.position + offset;

        else if (Time.time < startDelay) { float remaining = startDelay - Time.time; }
        


    }
}
