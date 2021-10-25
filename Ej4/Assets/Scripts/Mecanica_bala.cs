using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica_bala : MonoBehaviour
{
    public float speedBala = 5.0f;
    public Vector3 direction;
    public float damage = 25f;
    public float destroyBala;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        DestroyBalaMet();
        BigBala();
    }
    private void MoveEnemy()
    {
        transform.Translate(speedBala * Time.deltaTime * direction);
    }
    void DestroyBalaMet()
    {
        destroyBala -= Time.deltaTime;
        if (destroyBala < 0)
        {
            Destroy(gameObject);
        }
    }
    void BigBala()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale *= 2;
        }
    }
}
