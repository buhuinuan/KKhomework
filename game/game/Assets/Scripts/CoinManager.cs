using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject Door;
    void Start()
    {
        
    }

    
    void Update()
    {
        //判断子物体是否为0
        if (transform.childCount <= 0)
        {
            Destroy(Door);
            Destroy(gameObject);
        }
    }
}
