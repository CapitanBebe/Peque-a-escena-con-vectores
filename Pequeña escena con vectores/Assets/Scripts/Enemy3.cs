using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
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
        switch (enemyMove)
        {
            case EnemyMoves.Chasing:
                chasing();
                break;
            case EnemyMoves.Staring:
                staring();
                break;
        }
        
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
    void staring()
    {
    }
}
