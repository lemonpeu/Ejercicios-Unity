using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] float mouseXAxis;
    [SerializeField] float rotationSpeed = 10f;
    [SerializeField] float triggerTime = 0.04f;
    [SerializeField] float countTime = 0;
    private GameObject portal;
    private GameObject player;
    private GameObject wall;
    private bool isTrigger = true;
    private bool isCollide = true;

    // Start is called before the first frame update
    void Start()
    {
        portal = GameObject.FindWithTag("Portal");
        player = GameObject.Find("Toon Chicken");
        wall = GameObject.FindWithTag("Wall");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        RotatePlayer();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
    }

    private void RotatePlayer()
    {
        mouseXAxis += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0, mouseXAxis, 0);
        transform.rotation = newRotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerTime -= Time.deltaTime;

        if (isTrigger)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            if (triggerTime < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (triggerTime < 0)
        {
            triggerTime = 0.04f;
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") && isCollide)
        {
            countTime += Time.deltaTime;
            if (countTime > 2)
            {
                wall.transform.position = new Vector3(0.3f, 0.3f, 0.3f);
                wall.transform.rotation = Quaternion.Euler(0, 80, 0);
                countTime = 0;
                isCollide = false;


            }


        }

        if (collision.gameObject.CompareTag("Wall") && isCollide == false)
        {
            countTime += Time.deltaTime;
            if (countTime > 2)
            {
                wall.transform.position = new Vector3(2f, 0.5f, 3.8f);
                wall.transform.rotation = Quaternion.Euler(0, 54, 0);
                countTime = 0;
                isCollide = true;
            }


        }

    }

    private void OnCollisionEnter(Collision collision) 
    {
        Debug.Log(collision.gameObject.name);    
    }
}
