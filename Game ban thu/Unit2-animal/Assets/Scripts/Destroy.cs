using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 50)
            Destroy(gameObject);
        else if (transform.position.z < -2)
        {
            Debug.Log("Game Over");
            //Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
