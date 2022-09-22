using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("NormalBullet"))
        {
            hp -= 3;
        }
        if (other.CompareTag("SnipeBullet"))
        {
            hp -= 8;
        }
        if (other.CompareTag("RapidBullet"))
        {
            hp -= 1;
        }
    }
}
