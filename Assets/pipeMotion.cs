using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMotion : MonoBehaviour

{
    public float pipeSpeed = 1;
    public float deadZone = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
        
        if (transform.position.x < deadZone)
        {
            print(transform.position.x + " " + deadZone);
            Destroy(gameObject);
        }
    }
}
