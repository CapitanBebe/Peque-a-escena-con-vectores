using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    // Propiedades
    enum EnemyMoves { staringTime, chasingTime }
    [SerializeField] EnemyMoves enemyMove;
    [SerializeField] Transform target;
    public GameObject head;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(enemyMove)
        {
            case EnemyMoves.staringTime:
                staring();
                break;
            case EnemyMoves.chasingTime:
                chasing();
                break;
        }
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
    void staring()
    {
     head.transform.LookAt(target, Vector3.up);
    }
}
