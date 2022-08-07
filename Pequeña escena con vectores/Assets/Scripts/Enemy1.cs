using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform target;
    public float speed = 2f;
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
        if (direction.magnitude > 2f)
        {
            transform.position += (direction.normalized * speed * Time.deltaTime);
            transform.LookAt(target, Vector3.up);
        }
        if (direction.magnitude <= 2f)
        {
            transform.position -= (direction.normalized * speed * Time.deltaTime);
            transform.LookAt(target, Vector3.up);
        }
    }
}
