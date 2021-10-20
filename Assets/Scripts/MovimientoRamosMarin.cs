using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoRamosMarin : MonoBehaviour
{
    public int scaleObject = 2;
    public float moveObject = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(scaleObject, scaleObject, scaleObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveObject, 0, 0);
    }
}
