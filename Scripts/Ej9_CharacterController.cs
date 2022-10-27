using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej9_CharacterController : MonoBehaviour
{

    public float speed = 6f;
    public float rotationSpeed = 100f;

    private Transform t;
    private Vector3 horizontal;
    
    void Start() {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);

        if(Input.GetKey(KeyCode.Space)){
            speed = 12f;
        }else
            speed = 6f;
    }
}
