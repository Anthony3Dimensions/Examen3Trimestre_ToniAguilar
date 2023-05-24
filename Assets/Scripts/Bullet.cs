using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rBody;
    public float BulletSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.AddForce(transform.right * BulletSpeed,ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D()
    {
        Destroy(this.gameObject);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
