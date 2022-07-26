using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Fruit spawn")]
    public GameObject[] fruitsToSpawn;
    [Header("Bomb")]
    public GameObject bomb;
    public int bombProbability = 10;
    public Transform[] spawnPlaces;
    [Header("Spawn settings")]
    public float minWait = .3f;
    public float maxWait = 1f;
    public float minForce = 12;
    public float maxForce = 17;

    void Start()
    {
        StartCoroutine(SpawnFruits());    
    }

    private IEnumerator SpawnFruits()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));

            Transform t = spawnPlaces[Random.Range(0, spawnPlaces.Length)];

            GameObject elementToSpawn = null;
            float p = Random.Range(0, 100);

            if(p < bombProbability)
            {
                elementToSpawn = bomb;
            } else
            {
                elementToSpawn = fruitsToSpawn[Random.Range(0, fruitsToSpawn.Length)];
            }

            GameObject fruit = Instantiate(elementToSpawn, t.position, t.rotation);

            fruit.GetComponent<Rigidbody2D>().AddForce(t.transform.up * Random.Range(minForce, maxForce), ForceMode2D.Impulse);

            Destroy(fruit, 5);
        }
    }


}
