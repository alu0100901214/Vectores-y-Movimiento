using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    
    public Vector3 goal;
    public float speed = 3f;

    private Transform t;

    void Start() {
        t = GetComponent<Transform>();
    }

    
    
    void Update() {
        if(Input.GetKey(KeyCode.Space)) 
            t.Translate(goal * Time.deltaTime * speed);
        
    }
}

