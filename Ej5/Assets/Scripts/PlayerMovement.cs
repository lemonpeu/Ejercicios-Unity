using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    MovePlayer(Vector3.up);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    MovePlayer(Vector3.down);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    MovePlayer(Vector3.right);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    MovePlayer(Vector3.left);
        //}
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //transform.Translate(speedPlayer * Time.deltaTime * new Vector3(horizontal, vertical, 0));
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }

    //private void MovePlayer(Vector3 direction)
    //{
    //    transform.Translate(speed * Time.deltaTime * direction);
    //}
}
