using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] float mouseXAxis;
    [SerializeField] float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        RotatePlayer();
        //RotatePlayer2();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //transform.Translate(speedPlayer * Time.deltaTime * new Vector3(horizontal, vertical, 0));
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }

    private void RotatePlayer()
    {
        mouseXAxis += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0, mouseXAxis, 0);
        transform.rotation = newRotation;
    }

    //private void RotatePlayer2()
    //{
    //    float horizontal = Input.GetAxis("Horizontal");
    //    transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
    //}

}
