using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica_bala : MonoBehaviour
{
    public float speedBala = 5.0f;
    public Vector3 direction;
    public float damage = 25f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }
    private void MoveEnemy()
    {
        transform.Translate(speedBala * Time.deltaTime * direction);
    }
}
