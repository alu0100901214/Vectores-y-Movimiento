using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilinderCollision : MonoBehaviour
{

    private Renderer r;

    void Start(){
        r = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other){
        other.GetComponent<Ej10>().addPoints(100);
        r.material.SetColor("_Color", Color.red);
    }

    private void OnTriggerExit(Collider other){
        r.material.SetColor("_Color", Color.grey);
    }

}
