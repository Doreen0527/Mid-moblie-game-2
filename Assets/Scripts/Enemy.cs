using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float hp = 100f;
    public GameObject gold;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bullet")
        {
            
            Bullet bullet = other.GetComponent<Bullet>();

            
            hp -= bullet.atk;
            
            
            if (hp <= 0)
            {
                Instantiate(gold,this.transform.position,transform.rotation);
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
