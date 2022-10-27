using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public Vector3 right;
    public Vector3 left;
    public Vector3 forward;
    public Vector3 back;

    public float speed = 3f;

    private Transform t;
    
    
    void Start() {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) 
            t.Translate(right.normalized * Time.deltaTime * speed);

        if(Input.GetKey(KeyCode.D)) 
            t.Translate(left.normalized * Time.deltaTime * speed);

        if(Input.GetKey(KeyCode.W)) 
            t.Translate(forward.normalized * Time.deltaTime * speed);

        if(Input.GetKey(KeyCode.S)) 
            t.Translate(back.normalized * Time.deltaTime * speed);
    }
}