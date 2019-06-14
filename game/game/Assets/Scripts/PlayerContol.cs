using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContol : MonoBehaviour
{
    //声明Rigidbody组件
    private Rigidbody rBody ;
    //血量
    public int hp = 5;
    void Start()
    {
        //调用面板Rigidbody的数据给rBody
        rBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {//水平轴
       float horizontal = Input.GetAxis("Horizontal");
     //垂直轴
       float vertical = Input.GetAxis("Vertical");
        //方向
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if(dir != Vector3.zero)
        {
            //移动
            rBody.velocity = dir * 2;
        }

    }
    //只要碰到碰撞体，就会调用
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Wall")
        {
            hp--;
            if(hp <= 0)
            {
                //死掉
                AudioManager.Instance.PlayBomb();
                Destroy(gameObject);
            }
            else
            {
                AudioManager.Instance.PlayHip();
            }
        }
    }
}
