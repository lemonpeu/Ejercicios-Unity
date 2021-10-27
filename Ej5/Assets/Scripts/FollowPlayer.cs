using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset = new Vector3(4, 2, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
