using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinContal : MonoBehaviour
{
        void Start()
    {
        
    }

       void Update()
    {
        //金币旋转
        transform.Rotate(Vector3.forward * 90 * Time.deltaTime);
    }
    //触发调用
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AudioManager.Instance.PlayCoin();
            Destroy(gameObject);
        }
    }
}
