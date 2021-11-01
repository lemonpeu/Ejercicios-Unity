using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] float speedEnemy = 1f;
    private GameObject player;
    enum EnemiesTypes {Enemy1, Enemy2}
    [SerializeField] private EnemiesTypes enemies;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemies)
        {
            case EnemiesTypes.Enemy1:
                LookAtPlayer(player);
                MoveTowardsNoCollision();
                break;
            case EnemiesTypes.Enemy2:
                LookAtPlayer(player);
                MoveTowards();
                break;
            default:
                break;
        }

    }
    private void MoveTowardsNoCollision()
    {
        Vector3 direction = player.transform.position - transform.position;
        if (direction.magnitude > 2)
        {
            transform.position += speedEnemy * direction.normalized * Time.deltaTime;
        }
        
    }

    private void MoveTowards()
    {
        Vector3 direction = player.transform.position - transform.position;
        transform.position += speedEnemy * direction.normalized * Time.deltaTime;


    }

    private void LookAtPlayer(GameObject lookObject)
    {
        Vector3 direction = lookObject.transform.position - transform.position;
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = newQuaternion;
    }
}