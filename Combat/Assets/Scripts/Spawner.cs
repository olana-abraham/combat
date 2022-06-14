using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int spawnIndex;
    public Vector3 spawnLocation;
    public GameObject[] spawnType;
    public float yLocation;
    public float spawnRate;
    
    
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(transform.position.x,yLocation,transform.position.z);
        SpawnObject();
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        spawnIndex = UnityEngine.Random.Range(0,spawnType.Length);
        Instantiate(spawnType[spawnIndex],spawnLocation,Quaternion.identity);
    }

    private IEnumerator SpawnRoutine ()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            SpawnObject();
        }
    }
}
