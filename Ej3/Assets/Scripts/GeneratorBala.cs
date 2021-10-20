using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBala : MonoBehaviour
{
    public GameObject Bala;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnEnemy", 1.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        Instantiate(Bala, transform.position, Bala.transform.rotation);
    }
}
