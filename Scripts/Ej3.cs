using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{

    public GameObject goal;
    public float speed;

    private Transform tGoal;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        tGoal = goal.transform;
        speed = 2f;

        direction = tGoal.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
