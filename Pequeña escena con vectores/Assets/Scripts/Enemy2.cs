using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Propiedades
    [SerializeField] Transform targetPosition;
    public float speed = 2f;
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
        Vector3 direction = (targetPosition.position - transform.position);
        if (direction.magnitude > 2f)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        transform.LookAt(targetPosition);
    }
}
