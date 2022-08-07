using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    // Propiedades
    [SerializeField] Transform target;
    public float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chasing();
    }
    void chasing()
    {
        Vector3 direction = (target.position - transform.position);
        if(direction.magnitude > 2f)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        if (direction.magnitude < 2f)
        {
            transform.Translate(direction.normalized * -speed * Time.deltaTime);
        }
        transform.LookAt(target);
    }
}
