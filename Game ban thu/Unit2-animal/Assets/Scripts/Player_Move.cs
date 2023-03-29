using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player_Move : MonoBehaviour
{

    public float HorizaInput;
    public float speed;
    public GameObject food_prefabs;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10)
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        if (transform.position.x > 10)
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
       // di chuyển
        HorizaInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizaInput * speed * Time.deltaTime);
        //Bắn 
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(food_prefabs, transform.position, food_prefabs.transform.rotation);
        //chuột
        //if (Input.GetMouseButton(0))
        //{
        //    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // //   mousePos = new Vector3(Mathf.Clamp(mousePos.x, -10, 10), 0, Mathf.Clamp(mousePos.y, -20, 20) );
        //}
        //transform.position = Vector3.Lerp(transform.position, mousePos, 0.1f * Time.deltaTime);
    }
}
