using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capyube : MonoBehaviour
{
    public Transform Min;
    public Transform Max;

    public float inc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, Min.position.x, Max.position.x), transform.position.y, transform.position.z);
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, Min.position.x, Max.position.x), transform.position.y, transform.position.z);
        }
    }
}
