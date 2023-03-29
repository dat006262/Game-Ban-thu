using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animal_prefabs;
    void Start()
    {
        InvokeRepeating("Spawn_Random", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void Spawn_Random()
    {
        int random_animal = Random.Range(0, animal_prefabs.Length);
        Vector3 randomspawn = new Vector3(Random.Range(-10, 10), 0, 20);
        Instantiate(animal_prefabs[random_animal], randomspawn, animal_prefabs[random_animal].transform.rotation);
    }    
}
