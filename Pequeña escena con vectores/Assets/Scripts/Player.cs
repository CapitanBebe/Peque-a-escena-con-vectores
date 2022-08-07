using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Propiedades
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        movement();
    }
    void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up);
        }
    }

}
