using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBalasJ : MonoBehaviour
{
    public GameObject Bala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            SpawnEnemy();
        }
    }
    void SpawnEnemy()
    {
        Instantiate(Bala, transform.position, Bala.transform.rotation);
    }
}
