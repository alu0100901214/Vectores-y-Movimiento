using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    
    public Vector3 goal;
    public float speed = 3f;

    private Transform t;

    void Start() {
        t = GetComponent<Transform>();
    }

    
    
    void Update() {
        if(Input.GetKey(KeyCode.Space)) 
            t.Translate(goal.normalized * Time.deltaTime * speed);
        
    }
}

