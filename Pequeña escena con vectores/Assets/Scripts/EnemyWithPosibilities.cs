using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWithPosibilities : MonoBehaviour
{
    // Propiedades
    enum EnemyMoves { Staring, Chasing }
    [SerializeField] EnemyMoves enemyMove;
    [SerializeField] Transform targetPosition;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void chasing()
    {
        Vector3 direction = (targetPosition.position - transform.position);
        direction.Normalize();
        transform.Translate(direction.normalized * speed * Time.deltaTime);
        if(direction.magnitude < 2f)
        {
            speed = 0;
        }
    }
    void staring()
    {
        transform.RotateAround(targetPosition.position, Vector3.up, 20f * Time.deltaTime);
    }
}
