using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5 : MonoBehaviour
{

    public GameObject goal;
    public float speed;
    public float accuracy = 0.01f;

    private Transform tGoal;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        tGoal = goal.transform;
        this.transform.LookAt(tGoal.position);
        direction = tGoal.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(direction.magnitude > accuracy)
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
